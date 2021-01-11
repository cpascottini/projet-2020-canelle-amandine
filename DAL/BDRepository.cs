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
        
        public IList<BD> GetBDUtilisateur(int idUtilisateurLocal, string statut)
        {
            return Session.CreateQuery("select bd from BD as bd, Relation as r where bd.IdBD=r.BDRelation and r.PersonneRelation=:util and r.Statut=:statut").SetInt32("util", idUtilisateurLocal).SetString("statut",statut).List<BD>();
        }

        public IList<BD> GetBDRecherche(string rechercheLocal)
        {
            IList<BD> bdRecherche = Session.CreateQuery("select bd from BD bd where (bd.Titre like :r)" +
                "or (bd.Auteur like :r)" +
                "or (bd.Dessinateur like :r)" +
                "or (bd.Editeur like :r)" +
                "or (bd.Genre like :r)" +
                "or (bd.Serie like :r)").SetParameter("r", "%"+rechercheLocal+"%").List<BD>();

            return bdRecherche;
        }
        
        public IList<BD> GetBDRow(string titreLocal, string auteurLocal)
        {         
            return Session.CreateQuery("select bd from BD bd where bd.Titre=:titre and bd.Auteur=:auteur").SetString("titre", titreLocal).SetString("auteur", auteurLocal).List<BD>();
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
