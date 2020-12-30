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
            return Session.CreateQuery("select bd from BD bd where bd.Titre='" + titreLocal + "'" +
                "and bd.Auteur='" + auteurLocal + "'").List<BD>();
        }

        public void AjouterBD(BD bdLocal, int idUtilisateurLocal)
        {
            // màj des données
            Relation relation = new Relation();

            string requeteNbRelations = "select count(*) from Relation"; // Nb total de relations
            int nbRelations = (int)Session.CreateQuery(requeteNbRelations).UniqueResult<long>();
            relation.Id = nbRelations+1;

            string titre = bdLocal.Titre;
            string auteur = bdLocal.Auteur;
            string requeteIdBD = "select bd from BD bd where bd.Titre='"+titre+"' and bd.Auteur='"+auteur+"'";
            int IdBD = (int)Session.CreateQuery(requeteIdBD).UniqueResult<long>();
            relation.BD = IdBD;

            relation.Personne = idUtilisateurLocal;

            Session.SaveOrUpdate(relation); // Ajout d’une ligne dans la table Relation de la BD
        }

        public void Save(BD bd)
        {
            Session.Save(bd);
        }
    }
}
