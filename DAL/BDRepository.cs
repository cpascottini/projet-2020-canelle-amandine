using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class BDRepository : Repository, IBDRepository
    {
        public BDRepository()
        {

        }
        public IList<BD> GetAll()
        {
            return (Session.Query<BD>().ToList());
        }
        
        public IList<BD> GetBDUtilisateur()
        {
            int idUtilisateur = 3;        
            return Session.CreateQuery("select bd from BD as bd, Relation as r where bd.Id=r.BD and r.Personne=:util and r.Statut='possede'").SetInt32("util", idUtilisateur).List<BD>();
        }

        public IList<BD> GetBDRecherche(string rechercheLocal)
        {
            //string recherche = tbRecherche.Text;
            return Session.CreateQuery("select bd from BD bd where bd.Titre like " + rechercheLocal).List<BD>();
        }
        
        public void Save(BD bd)
        {
            Session.Save(bd);
        }
    }
}
