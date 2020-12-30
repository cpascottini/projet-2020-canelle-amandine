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

            while(true)
            {
                IPersonneRepository personneRepository = new PersonneRepository();
                LoginForm loginForm = new LoginForm(personneRepository, bdRepository);

                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    int idUtilisateur = personneRepository.GetIdUtilisateur(loginForm.Login, loginForm.Password);
                    Application.Run(new MainForm(bdRepository, idUtilisateur));
                }
            }           
        }
    }
}
