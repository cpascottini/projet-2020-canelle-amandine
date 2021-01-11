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
    public partial class InscriptionForm : Form
    {
        private IPersonneRepository personneRepository;

        public InscriptionForm(IPersonneRepository personneRepository)
        {
            InitializeComponent();
            this.personneRepository = personneRepository;
        }

        public string NewLogin
        {
            get { return tbNewLogin.Text; }
            set { tbNewLogin.Text = value; }
        }

        public string NewPassword
        {
            get { return tbNewPassword.Text; }
            set { tbNewPassword.Text = value; }
        }

        private void btnInscriptionConfirmer_Click(object sender, EventArgs e)
        {
            personneRepository.SaveUtilisateur(NewLogin, NewPassword);
            MessageBox.Show("Inscription à la BDthèque réussie.\nBienvenue !", "Inscription réussie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnInscriptionAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // pour se connecter en appuyant sur entrée
        {
            if (keyData == (Keys.Enter))
            {
                btnInscriptionConfirmer.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
