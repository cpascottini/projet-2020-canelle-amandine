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
        private string fileToCopy { get; set; }

        public AjoutAlbumForm(IBDRepository bdRepository)
        {
            this.bdRepository = bdRepository;
            InitializeComponent();
            couverture = "";
            fileToCopy = "";
            cbAjoutCategorie.SelectedIndex = 0;
        }

        private void btnAjoutValider_Click(object sender, EventArgs e)
        {
            bool BDAjoutee = false;
            if (tbAjoutAuteur.Text == "" | tbAjoutDessinateur.Text =="" | tbAjoutEditeur.Text == "" |
                tbAjoutGenre.Text == "" | cbAjoutCategorie.Text=="" | tbAjoutTitre.Text == "" | couverture == "")
                // un des champs obligatoires n'est pas rempli
                // pas obligatoire de remplir le champ Série ni son numéro
            {
                MessageBox.Show("Un ou plusieurs champs sont vides.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // tout est correctement rempli
            {
                string titre = tbAjoutTitre.Text;
                string auteur = tbAjoutAuteur.Text;
                string dessinateur = tbAjoutDessinateur.Text;
                string editeur = tbAjoutEditeur.Text;
                string genre = tbAjoutGenre.Text;
                string categorie = cbAjoutCategorie.Text;

                if (bdRepository.GetBDRow(titre, auteur).Count() != 0)
                    // une BD avec le même titre et le même auteur existe déjà
                {
                    MessageBox.Show("Cet album existe déjà.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // la BD n'existe pas encore
                {
                    if (bdRepository.GetAllCouvertures().Contains(couverture))
                    // une couverture du même nom existe déjà dans la DB
                    {
                        MessageBox.Show("Ce nom d'image est déjà pris.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (tbAjoutSerie.Text == "")
                        // la BD ne fait pas partie d'une série
                        {
                            if ((int)nudAjoutNumSerie.Value != 0)
                            // l'admin a entré un n° de série sans saisir de nom de série
                            {
                                MessageBox.Show("L'album ne fait pas partie d'une série, vous ne pouvez pas saisir de n°.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {                               
                                bdRepository.SaveBD(titre, auteur, dessinateur, editeur, genre, couverture, categorie);
                                BDAjoutee = true;
                            }
                        }
                        else // la BD fait partie d'une série
                        {
                            string serie = tbAjoutSerie.Text;
                            int numSerie = (int)nudAjoutNumSerie.Value;
                            bdRepository.SaveBD(titre, auteur, dessinateur, editeur, genre, couverture, serie, numSerie, categorie);
                            BDAjoutee = true;
                        }                        
                    }                    
                }
                if (BDAjoutee)
                {
                    // copie de l'image dans le répertoire app/bin/debug/couvertures
                    string destinationDirectory = @"couvertures\";
                    System.IO.File.Copy(fileToCopy, destinationDirectory + System.IO.Path.GetFileName(fileToCopy));

                    string message = String.Format("Le nouvel album '{0}' a bien été enregistré.", titre);
                    MessageBox.Show(message, "Album enregistré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
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

                fileToCopy = open.FileName; // on récupère le nom de l'image pour quand on enregistrera la BD
            }
        }

        private void btnAjoutAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
