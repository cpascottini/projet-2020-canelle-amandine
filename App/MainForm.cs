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
        public MainForm(IBDRepository bdRepository)
        {
            InitializeComponent();

            this.bdRepository = bdRepository;
            AfficherContenu();
        }

        private void AfficherContenu()
        {
            try
            {
                // BD du marché
                dgvAllAlbums.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des BD et remplissage du tableau
                foreach (BD bd in bdRepository.GetAll())
                {
                    dgvAllAlbums.Rows.Add(bd.Decrire());
                }
                

                // tri alphabétique sur la 1ère colonne (nom)
                dgvAllAlbums.Sort(dgvAllAlbums.Columns[0], ListSortDirection.Ascending);


                // BD de l'utilisateur connecté
                dgvMyAlbums.Rows.Clear();  // suppression des éventuelles lignes existantes
                // Accès à la liste des BD et remplissage du tableau
                foreach (BD bd in bdRepository.GetBDUtilisateur())
                {
                    dgvMyAlbums.Rows.Add(bd.Decrire());
                }
                // tri alphabétique sur la 1ère colonne (nom)
                dgvMyAlbums.Sort(dgvMyAlbums.Columns[0], ListSortDirection.Ascending);


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

        private void dgvMyAlbums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = this.dgvMyAlbums.Rows[rowIndex];
            string titre = row.Cells["columnMyTitre"].Value.ToString();
            string auteur = row.Cells["columnMyScenariste"].Value.ToString();

            AlbumForm albumForm = new AlbumForm(bdRepository, titre, auteur);
            albumForm.ShowDialog();
        }
    }
}
