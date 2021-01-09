using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App;
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
        private bool hasTbRechercheBeenEdited = false;
        private IList<BD> BDUtilisateur ;
        private IList<BD> BDWishlist;


        public MainForm(IBDRepository bdRepository, IRelationRepository relationRepository, IPersonneRepository personneRepository, int idUtilisateur)
        {
            InitializeComponent();

            this.bdRepository = bdRepository;
            this.relationRepository = relationRepository;
            this.personneRepository = personneRepository;
            this.idUtilisateur = idUtilisateur;
            MajBDUtilisateur();


            string roleUtilisateur = personneRepository.GetRoleUtilisateur(idUtilisateur);
            // si la personne connectée n'est pas un admin elle ne peut pas ajouter d'album au marché
            if (roleUtilisateur!="administrateur")
            {
                btnAjouterAlbum.Visible = false;
            }
            AfficherContenu();
        }

        private void MajBDUtilisateur()
        {
            BDUtilisateur = bdRepository.GetBDUtilisateur(idUtilisateur, "possede");
            BDWishlist = bdRepository.GetBDUtilisateur(idUtilisateur, "veut");
        }

        private void AfficherContenu()
        {
            try
            {
                // BD QUE POSSEDE L'UTILISATEUR CONNECTÉ
                AfficherBDUtilisateur(dgvMyAlbums, BDUtilisateur);

                // BD QUE VEUT L'UTILISATEUR CONNECTÉ               
                AfficherBDUtilisateur(dgvWishlist, BDWishlist);
                
                // BD DU MARCHÉ
                AfficherBDMarche(bdRepository.GetAll());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfficherBDMarche(IList<BD> listeBD)
        {
            dgvAllAlbums.Rows.Clear();  // suppression des éventuelles lignes existantes
                                        // Accès à la liste des BD et remplissage du tableau
            foreach (BD bd in listeBD)
            {
                bool possede = BDUtilisateur.Contains(bd);
                bool veut = BDWishlist.Contains(bd);
                dgvAllAlbums.Rows.Add(bd.DecrireBDMarche(possede, veut));
            }
            // tri alphabétique sur la 1ère colonne (titre)
            dgvAllAlbums.Sort(dgvAllAlbums.Columns[0], ListSortDirection.Ascending);
        }

        private void AfficherBDUtilisateur(DataGridView dgv, IList<BD> listeBD)
        {
            dgv.Rows.Clear();  // suppression des éventuelles lignes existantes
                                       // Accès à la liste des BD et remplissage du tableau
            foreach (BD bd in listeBD)
            {
                dgv.Rows.Add(bd.Decrire());
            }
            // tri alphabétique sur la 1ère colonne (titre)
            dgv.Sort(dgv.Columns[0], ListSortDirection.Ascending);
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {           
            string recherche = tbRecherche.Text;

            // on réaffiche le dgv si une recherche précédente les a cachées
            dgvAllAlbums.Show();

            // on remasque le label si une recherche précédente l'a affichée
            labelPasDeResultat.Visible = false;

            dgvAllAlbums.Rows.Clear();  // suppression des éventuelles lignes existantes
            IList<BD> BDRecherche = bdRepository.GetBDRecherche(recherche);
            if (BDRecherche.Count() != 0)
            {
                AfficherBDMarche(BDRecherche);
            }
            else // s'il n'y a pas de résultat
            {
                dgvAllAlbums.Hide();

                labelPasDeResultat.Visible = true;
                labelPasDeResultat.Text = "Aucun résultat pour cette recherche.";
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // pour rechercher en appuyant sur entrée
        {
            if (keyData == (Keys.Enter))
            {
                btnRecherche.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            tbRecherche.Text = "";
            AfficherBDMarche(bdRepository.GetAll());
        }

        private void dgvAllAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = this.dgvAllAlbums.Rows[rowIndex];
            string titre = row.Cells["columnAllTitre"].Value.ToString();
            string auteur = row.Cells["columnAllScenariste"].Value.ToString();
            IList<BD> bdRow = bdRepository.GetBDRow(titre, auteur);
            BD bd = bdRow[0];

            bool showAlbum = true;

            // ajout d'une BD du marché à sa liste d'envies    
            DataGridViewCheckBoxCell caseAjoutWishlist = (DataGridViewCheckBoxCell)dgvAllAlbums.Rows[rowIndex].Cells["columnWishlist"];
            if (caseAjoutWishlist.Selected && !Convert.ToBoolean(caseAjoutWishlist.Value))
            {
                showAlbum = false;

                if (BDUtilisateur.Contains(bd))
                    // si la BD est déjà dans les possessions de l'utilisateur
                {
                    string message = String.Format("Vous possédez déjà l'album '{0}'.", bd.Titre);
                    MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // ajouter la BD du row à la liste d'envies
                    relationRepository.SaveRelation(bd, idUtilisateur, "veut");
                    string message = String.Format("L'album '{0}' a bien été ajouté à votre wishlist.", bd.Titre);
                    MessageBox.Show(message, "Ajout à la wishlist", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
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

            // on n'affiche la description d'un album que si le clic n'a pas lieu sur une colonne à cocher
            if (showAlbum==true)
            {
                AlbumForm albumForm = new AlbumForm(bdRepository, titre, auteur);
                albumForm.ShowDialog();
                
            }
            else
            {
                MajBDUtilisateur();
                AfficherContenu(); // on réaffiche le contenu pour mettre les données à jour
            }
        }

        private void dgvWishlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = this.dgvWishlist.Rows[rowIndex];
            string titre = row.Cells["columnWishTitre"].Value.ToString();
            string auteur = row.Cells["columnWishScenariste"].Value.ToString();

            AlbumForm albumForm = new AlbumForm(bdRepository, titre, auteur);
            albumForm.ShowDialog();
        }
        private void dgvMyAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = this.dgvMyAlbums.Rows[rowIndex];
            string titre = row.Cells["columnMyTitre"].Value.ToString();
            string auteur = row.Cells["columnMyScenariste"].Value.ToString();

            AlbumForm albumForm = new AlbumForm(bdRepository, titre, auteur);
            albumForm.ShowDialog();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {            
            this.Close();    
        }

        private void btnAjouterAlbum_Click(object sender, EventArgs e)
        {
            AjoutAlbumForm ajoutAlbumForm = new AjoutAlbumForm(bdRepository);
            ajoutAlbumForm.ShowDialog();
            AfficherBDMarche(bdRepository.GetAll());
        }

        private void tbRecherche_Enter(object sender, EventArgs e)
        {
            if(!hasTbRechercheBeenEdited)
            {
                tbRecherche.Text = "";
                tbRecherche.ForeColor = Color.Black;
                hasTbRechercheBeenEdited = true;
            }          
        }
    }
}
