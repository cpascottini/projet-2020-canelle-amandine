using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class PersonneRepository : Repository, IPersonneRepository
    {
        public List<Personne> GetAll()
        {
            return Session.Query<Personne>().ToList();
        }
        public int GetIdUtilisateur(string loginLocal, string mdpLocal)
        {
            string requete = "select Id from Personne p where p.Login='" + loginLocal + "' and p.Mdp='" + mdpLocal + "'";
            int idUtilisateur = (int)Session.CreateQuery(requete).UniqueResult<int>();

            return idUtilisateur;
        }
    }
}
