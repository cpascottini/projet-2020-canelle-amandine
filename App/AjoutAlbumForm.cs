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

        public AjoutAlbumForm(IBDRepository bdRepository)
        {
            this.bdRepository = bdRepository;
            InitializeComponent();
        }

        private void btnAjoutValider_Click(object sender, EventArgs e)
        {
            if (tbAjoutAuteur.Text == "" | tbAjoutDessinateur.Text =="" | tbAjoutEditeur.Text == "" |
                tbAjoutGenre.Text == "" | tbAjoutTitre.Text == "")
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
                    bdRepository.SaveBD(titre, auteur, dessinateur, editeur, genre);
                }
                else
                {
                    string serie = tbAjoutSerie.Text;
                    bdRepository.SaveBD(titre, auteur, dessinateur, editeur, genre,serie);
                }
            }
        }
    }
}
