using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace ProjetGL
{
    public partial class MainForm : Form
    {
        private IBDRepository bdRepository;
        private IRelationRepository relationRepository;
        private IPersonneRepository personneRepository;
        private int idUtilisateur;

        public MainForm(IBDRepository bdRepository, IRelationRepository relationRepository, IPersonneRepository personneRepository, int idUtilisateur)
        {
            InitializeComponent();

            this.bdRepository = bdRepository;
            this.relationRepository = relationRepository;
            this.personneRepository = personneRepository;
            this.idUtilisateur = idUtilisateur;
           
            string roleUtilisateur = personneRepository.GetRoleUtilisateur(idUtilisateur);
            // si la personne connectée n'est pas un admin elle ne peut pas ajouter d'album au marché
            if (roleUtilisateur!="administrateur")
            {
                btnAjouterAlbum.Visible = false;
            }
            AfficherContenu();
        }

        private void AfficherContenu()
        {
            try
            {
                // BD QUE POSSEDE L'UTILISATEUR CONNECTÉ
                IList<BD> BDUtilisateur = bdRepository.GetBDUtilisateur(idUtilisateur);

                dgvMyAlbums.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des BD et remplissage du tableau
                foreach (BD bd in BDUtilisateur)
                {
                    dgvMyAlbums.Rows.Add(bd.Decrire());
                }
                // tri alphabétique sur la 1ère colonne (nom)
                dgvMyAlbums.Sort(dgvMyAlbums.Columns[0], ListSortDirection.Ascending);



                // BD QUE VEUT L'UTILISATEUR CONNECTÉ
                IList<BD> BDWishlist = bdRepository.GetBDWishlist(idUtilisateur);

                dgvWishlist.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des BD et remplissage du tableau
                foreach (BD bd in BDWishlist)
                {
                    dgvWishlist.Rows.Add(bd.Decrire());
                }
                // tri alphabétique sur la 1ère colonne (nom)
                dgvWishlist.Sort(dgvWishlist.Columns[0], ListSortDirection.Ascending);



                // BD DU MARCHÉ
                dgvAllAlbums.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des BD et remplissage du tableau
                foreach (BD bd in bdRepository.GetAll())
                {
                    bool possede = BDUtilisateur.Contains(bd);
                    bool veut = BDWishlist.Contains(bd);
                    dgvAllAlbums.Rows.Add(bd.DecrireBDMarche(possede,veut));
                }
                // tri alphabétique sur la 1ère colonne (nom)
                dgvAllAlbums.Sort(dgvAllAlbums.Columns[0], ListSortDirection.Ascending);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            string recherche = tbRecherche.Text;

            // on réaffiche le dgv si une recherche précédente les a cachées
            dgvAllAlbums.Show();

            // on remasque le label si une recherche précédente l'a affichée
            labelPasDeResultat.Visible = false;

            dgvAllAlbums.Rows.Clear();  // suppression des éventuelles lignes existantes
            if (bdRepository.GetBDRecherche(recherche).Count() != 0)
            {
                foreach (BD bd in bdRepository.GetBDRecherche(recherche))
                {
                    dgvAllAlbums.Rows.Add(bd.Decrire());
                }
                dgvAllAlbums.Sort(dgvAllAlbums.Columns[0], ListSortDirection.Ascending);
            }
            else
            {
                dgvAllAlbums.Hide();

                labelPasDeResultat.Visible = true;
                labelPasDeResultat.Text = "Aucun résultat pour cette recherche.";
            }
        }

        private void dgvAllAlbums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = this.dgvAllAlbums.Rows[rowIndex];
            string titre = row.Cells["columnAllTitre"].Value.ToString();
            string auteur = row.Cells["columnAllScenariste"].Value.ToString();
            IList<BD> bdRow = bdRepository.GetBDRow(titre, auteur);
            BD bd = bdRow[0];

            // on n'affiche la description d'un album que si le clic n'a pas lieu sur une colonne à cocher
            bool showAlbum = true;

            // ajout d'une BD du marché à sa liste d'envies    
            DataGridViewCheckBoxCell caseAjoutWishlist = (DataGridViewCheckBoxCell)dgvAllAlbums.Rows[rowIndex].Cells["columnWishlist"];
            if (caseAjoutWishlist.Selected && !Convert.ToBoolean(caseAjoutWishlist.Value))
            {
                showAlbum = false;

                // ajouter la BD du row à la liste d'envies
                relationRepository.SaveRelation(bd, idUtilisateur, "veut");
                string message = String.Format("L'album '{0}' a bien été ajouté à votre wishlist.", bd.Titre);
                MessageBox.Show(message, "Ajout à la wishlist", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            // ajout d'une BD du marché à ses possessions
            DataGridViewCheckBoxCell caseAjoutPossession = (DataGridViewCheckBoxCell)dgvAllAlbums.Rows[rowIndex].Cells["columnMyAlbums"];          
            if (caseAjoutPossession.Selected && !Convert.ToBoolean(caseAjoutPossession.Value))
            {
                showAlbum = false;

                if (Convert.ToBoolean(caseAjoutWishlist.Value))    // si la BD était dans la liste d'envie on l'enlève
                {
                    // ajouter la BD du row à la liste des possessions et la supprimer de la wishlist
                    relationRepository.UpdateRelation(bd, idUtilisateur);
                    string message = String.Format("L'album '{0}' a bien été ajouté à votre BDthèque et supprimé de votre wishlist.", bd.Titre);
                    MessageBox.Show(message, "Ajout à la BDthèque", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    caseAjoutWishlist.Value = false;
                }
                else
                {
                    // ajouter la BD du row à la liste des possessions
                    relationRepository.SaveRelation(bd, idUtilisateur, "possede");
                    string message = String.Format("L'album '{0}' a bien été ajouté à votre BDthèque.", bd.Titre);
                    MessageBox.Show(message, "Ajout à la BDthèque", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

            // suppression d'une BD de sa wishlist
            if (caseAjoutWishlist.Selected && Convert.ToBoolean(caseAjoutWishlist.Value))
            {
                showAlbum = false;

                // supprimer la BD du row de la wishlist
                relationRepository.DeleteRelation(bd, idUtilisateur, "veut");
                string message = String.Format("L'album '{0}' a bien été retiré de votre wishlist.", bd.Titre);
                MessageBox.Show(message, "Retrait d'un album de la wishlist", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            
            // suppression d'une BD de ses possessions
            if (caseAjoutPossession.Selected && Convert.ToBoolean(caseAjoutPossession.Value)) 
            {
                showAlbum = false;

                // supprimer la BD du row de la liste des possessions
                relationRepository.DeleteRelation(bd, idUtilisateur, "possede");
                string message = String.Format("L'album '{0}' a bien été retiré de votre BDthèque.", bd.Titre);
                MessageBox.Show(message, "Retrait d'un album de la BDthèque", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            

            if (showAlbum==true)
            {
                AlbumForm albumForm = new AlbumForm(bdRepository, titre, auteur);
                albumForm.ShowDialog();
            }
        }

        private void dgvWishlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = this.dgvWishlist.Rows[rowIndex];
            string titre = row.Cells["columnWishTitre"].Value.ToString();
            string auteur = row.Cells["columnWishScenariste"].Value.ToString();

            AlbumForm albumForm = new AlbumForm(bdRepository, titre, auteur);
            albumForm.ShowDialog();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez été déconnecté.", "Déconnexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);            
            this.Close();
        }

        private void btnAjouterAlbum_Click(object sender, EventArgs e)
        {
            AjoutAlbumForm ajoutAlbumForm = new AjoutAlbumForm(bdRepository);
            ajoutAlbumForm.ShowDialog();
        }
    }
}
