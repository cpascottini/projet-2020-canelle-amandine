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

        public LoginForm(IPersonneRepository personneRepository)
        {
            InitializeComponent();
            this.personneRepository = personneRepository;
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
            
            /*// Contrôle de la saisie
            if (Login == "my user" && Password == "my pass")
            {
                //save the user has logged in somewhere
                //set the dialog result to ok
                this.DialogResult = DialogResult.OK;
                //close the dialog
                this.Close();
            }
            else
            {
                //login failed
                MessageBox.Show("Login failed");
                //do not close the window
            }*/
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
    }
}
