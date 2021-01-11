using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IPersonneRepository
    {
        IList<Personne> GetAll();
        int GetIdUtilisateur(string loginLocal, string mdpLocal);
        string GetRoleUtilisateur(int idUtilisateurLocal);
        void SaveUtilisateur(string loginLocal, string mdpLocal);

    }
}
