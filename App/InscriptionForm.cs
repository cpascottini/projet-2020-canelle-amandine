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
    public partial class InscriptionForm : Form
    {
        public InscriptionForm()
        {
            InitializeComponent();
        }

        public bool passwordsEqual()
        {
            return tbNewPassword.Text == tbNewPassword2.Text;
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
    }
}
