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
    public partial class LoginForm : Form
    {
        private IPersonneRepository personneRepository;
        private IBDRepository bdRepository;

        public LoginForm(IPersonneRepository personneRepository, IBDRepository bdRepository)
        {
            InitializeComponent();
            this.personneRepository = personneRepository;
            this.bdRepository = bdRepository;
        }

        public string Login
        {
            get { return tbLogin.Text; }
            set { tbLogin.Text = value; }
        }

        public string Password
        {
            get { return tbPassword.Text; }
            set { tbPassword.Text = value; }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            List<Personne> personnes = personneRepository.GetAll();
            bool validLogin = false;
            foreach(Personne p in personnes)
            {
                if(p.Login==Login && p.Mdp==Password)
                {
                    validLogin = true;
                }
            }
            if(validLogin)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Mauvais identifiant / mot de passe !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 

        private void linkInscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InscriptionForm inscriptionForm = new InscriptionForm();
            if (inscriptionForm.ShowDialog() == DialogResult.OK)
            {
                 string login = inscriptionForm.NewLogin;
                 string password = inscriptionForm.NewPassword;  
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // pour se connecter en appuyant sur entrée
        {
            if(keyData == (Keys.Enter))
            {
                btnConnexion.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
