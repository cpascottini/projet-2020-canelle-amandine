using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            
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
