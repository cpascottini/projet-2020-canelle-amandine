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
    public partial class MainForm : Form
    {
        public bool connected;

        public MainForm()
        {
            connected = false;
            LoginForm loginForm = new LoginForm();
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                InitializeComponent();
                cbRecherche.SelectedIndex = 0;
            }
        }
    }
}
