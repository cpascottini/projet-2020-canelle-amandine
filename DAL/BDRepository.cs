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
            int idUtilisateur = 3;        // il faut le récupérer 
            return Session.CreateQuery("select bd from BD as bd, Relation as r where bd.Id=r.BD and r.Personne=:util and r.Statut='possede'").SetInt32("util", idUtilisateur).List<BD>();
        }

        public IList<BD> GetBDRecherche(string rechercheLocal)
        {
            //IList<BD> bdRecherche = Session.CreateQuery("select bd from BD bd where bd.Titre like '%" + rechercheLocal + "%'").List<BD>();
            IList<BD> bdRecherche = Session.CreateQuery("select bd from BD bd where bd.Titre like '%" + rechercheLocal + "%'" +
                "or bd.Auteur like '%" + rechercheLocal + "%'" +
                "or bd.Dessinateur like '%" + rechercheLocal + "%'" +
                "or bd.Editeur like '%" + rechercheLocal + "%'" +
                "or bd.Genre like '%" + rechercheLocal + "%'" +
                "or bd.Serie like '%" + rechercheLocal + "%'").List<BD>();

            return bdRecherche;
        }
        
        public IList<BD> GetBDRow(string titreLocal, string auteurLocal)
        {
            return Session.CreateQuery("select bd from BD bd where bd.Titre='" + titreLocal + "'" +
                "and bd.Auteur='" + auteurLocal + "'").List<BD>();
        }

        public void Save(BD bd)
        {
            Session.Save(bd);
        }
    }
}
