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
        public IList<BD> GetAll()
        {
            return (Session.Query<BD>().ToList());
        }
        
        public IList<BD> GetBDUtilisateur(int idUtilisateurLocal)
        {
            return Session.CreateQuery("select bd from BD as bd, Relation as r where bd.Id=r.BD and r.Personne=:util and r.Statut='possede'").SetInt32("util", idUtilisateurLocal).List<BD>();
        }

        public IList<BD> GetBDWishlist(int idUtilisateurLocal)
        {
            return Session.CreateQuery("select bd from BD as bd, Relation as r where bd.Id=r.BD and r.Personne=:util and r.Statut='veut'").SetInt32("util", idUtilisateurLocal).List<BD>();
        }

        public IList<BD> GetBDRecherche(string rechercheLocal)
        {
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
            return Session.CreateQuery("select bd from BD bd where bd.Titre='" + titreLocal + "' and bd.Auteur='" + auteurLocal + "'").List<BD>();
        }

        public void SaveBD(string titreLocal, string auteurLocal, string dessinateurLocal, string editeurLocal,
            string genreLocal, string couvertureLocal, string serieLocal)
        {
            BD bd = new BD();
            bd.Titre = titreLocal;
            bd.Auteur = auteurLocal;
            bd.Dessinateur = dessinateurLocal;
            bd.Editeur = editeurLocal;
            bd.Genre = genreLocal;
            bd.Couverture = couvertureLocal;
            bd.Serie = serieLocal;

            Session.SaveOrUpdate(bd); // Ajout d’une ligne dans la table BD de la DB
            Session.Flush();
        }
        public void SaveBD(string titreLocal, string auteurLocal, string dessinateurLocal, string editeurLocal,
            string genreLocal, string couvertureLocal)
        {
            BD bd = new BD();
            bd.Titre = titreLocal;
            bd.Auteur = auteurLocal;
            bd.Dessinateur = dessinateurLocal;
            bd.Editeur = editeurLocal;
            bd.Genre = genreLocal;
            bd.Couverture = couvertureLocal;

            Session.SaveOrUpdate(bd); // Ajout d’une ligne dans la table BD de la DB
            Session.Flush();
        }
    }
}
