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
    public partial class AlbumForm : Form
    {
        private IBDRepository bdRepository;

        public AlbumForm(IBDRepository bdRepository, string titre, string auteur)
        {
            InitializeComponent();

            this.bdRepository = bdRepository;
            AfficherContenu(titre, auteur);
        }

        private void AfficherContenu(string titreLocal, string auteurLocal)
        {
            try
            {
                IList<BD> bdRow = bdRepository.GetBDRow(titreLocal, auteurLocal);
                
                tbTitre.Text = titreLocal;
                tbAuteur.Text = auteurLocal;
                tbDessinateur.Text = bdRow[0].Dessinateur;
                tbEditeur.Text = bdRow[0].Editeur;
                tbSerie.Text = bdRow[0].Serie;
                tbGenre.Text = bdRow[0].Genre;
                
                /*
                Bitmap couverture = new Bitmap(bdRow[0].Couverture);
                pictureBoxCouverture.Image = (Image) couverture;
                */

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
