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
        private int idUtilisateur;

        public MainForm(IBDRepository bdRepository, IRelationRepository relationRepository, int idUtilisateur)
        {
            InitializeComponent();

            this.bdRepository = bdRepository;
            this.relationRepository = relationRepository;
            this.idUtilisateur = idUtilisateur;
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

            AlbumForm albumForm = new AlbumForm(bdRepository, titre, auteur);
            albumForm.ShowDialog();
        }

        private void dgvAllAlbums_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = this.dgvAllAlbums.Rows[rowIndex];
            string titre = row.Cells["columnAllTitre"].Value.ToString();
            string auteur = row.Cells["columnAllScenariste"].Value.ToString();

            DataGridViewCheckBoxCell caseAjoutPossession = (DataGridViewCheckBoxCell)dgvAllAlbums.Rows[rowIndex].Cells["columnMyAlbums"];
            if (Convert.ToBoolean(caseAjoutPossession.Value)) // si la case est cochée 
            {
                // ajouter la BD du row à la liste des possessions
                IList<BD> bdRow = bdRepository.GetBDRow(titre, auteur);
                BD bd = bdRow[0];

                relationRepository.SaveRelation(bd, idUtilisateur);
                string message = String.Format("L'album '{0}' a bien été ajouté à votre BDthèque", bd.Titre);
                MessageBox.Show(message, "Ajout à la BDthèque", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dgvMyAlbums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = this.dgvMyAlbums.Rows[rowIndex];
            string titre = row.Cells["columnMyTitre"].Value.ToString();
            string auteur = row.Cells["columnMyScenariste"].Value.ToString();

            AlbumForm albumForm = new AlbumForm(bdRepository, titre, auteur);
            albumForm.ShowDialog();
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
    }
}
