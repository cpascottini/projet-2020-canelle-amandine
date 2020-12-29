using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace ProjetGL
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IBDRepository bdRepository = new BDRepository();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IPersonneRepository personneRepository = new PersonneRepository();
            LoginForm login_form = new LoginForm(personneRepository);
            if (login_form.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(bdRepository));
            }
        }
    }
}
