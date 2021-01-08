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
    public partial class AjoutAlbumForm : Form
    {
        private IBDRepository bdRepository;
        private string couverture { get; set; }

        public AjoutAlbumForm(IBDRepository bdRepository)
        {
            this.bdRepository = bdRepository;
            InitializeComponent();
        }

        private void btnAjoutValider_Click(object sender, EventArgs e)
        {
            if (tbAjoutAuteur.Text == "" | tbAjoutDessinateur.Text =="" | tbAjoutEditeur.Text == "" |
                tbAjoutGenre.Text == "" | tbAjoutTitre.Text == "" | couverture == "")
                // pas obligatoire de remplir le champ Série
            {
                MessageBox.Show("Un ou plusieurs champs sont vides.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string titre = tbAjoutTitre.Text;
                string auteur = tbAjoutAuteur.Text;
                string dessinateur = tbAjoutDessinateur.Text;
                string editeur = tbAjoutEditeur.Text;
                string genre = tbAjoutGenre.Text;

                if (tbAjoutSerie.Text == "")
                {
                    bdRepository.SaveBD(titre, auteur, dessinateur, editeur, genre, couverture);
                }
                else
                {
                    string serie = tbAjoutSerie.Text;
                    bdRepository.SaveBD(titre, auteur, dessinateur, editeur, genre, couverture, serie);
                }

                string message = String.Format("Le nouvel album '{0}' a bien été enregistré.", titre);
                MessageBox.Show(message, "Album enregistré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        
        private void btnAjoutParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // filtre d'extensions  
            open.Filter = "Image Files(*.jpg; *.jpeg)|*.jpg; *.jpeg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // affichage de l'image  
                pictureBoxAjoutCouverture.Image = new Bitmap(open.FileName);
                pictureBoxAjoutCouverture.SizeMode = PictureBoxSizeMode.StretchImage;

                // nom de l'image pour la DB
                couverture = open.SafeFileName;

                // copie de l'image dans le répertoire app/bin/debug/couvertures
                string fileToCopy = open.FileName;
                string destinationDirectory = @"couvertures\";
                System.IO.File.Copy(fileToCopy, destinationDirectory + System.IO.Path.GetFileName(fileToCopy));
            }
        }

        private void btnAjoutAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
