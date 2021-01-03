using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class RelationRepository : Repository, IRelationRepository
    {
        public List<Relation> GetAll()
        {
            return Session.Query<Relation>().ToList();
        }
        public void SaveRelation(BD bdLocal, int idUtilisateurLocal, string statutLocal)
        {
            Relation relation = new Relation();

            string titre = bdLocal.Titre;
            string auteur = bdLocal.Auteur;
            string requeteIdBD = "select Id from BD bd where bd.Titre='" + titre + "' and bd.Auteur='" + auteur + "'";
            int idBD = (int)Session.CreateQuery(requeteIdBD).UniqueResult<int>();
            relation.BD = idBD;

            relation.Personne = idUtilisateurLocal;
            relation.Statut = statutLocal;

            Session.SaveOrUpdate(relation); // Ajout d’une ligne dans la table Relation de la DB
            Session.Flush();
        }
        public void UpdateRelation(BD bdLocal, int idUtilisateurLocal)
        {
            string titre = bdLocal.Titre;
            string auteur = bdLocal.Auteur;
            string requeteIdBD = "select Id from BD bd where bd.Titre='" + titre + "' and bd.Auteur='" + auteur + "'";
            int idBD = (int)Session.CreateQuery(requeteIdBD).UniqueResult<int>();

            string requeteIdRelation = "select Id from Relation r where r.BD=" + idBD + " and r.Personne=" + idUtilisateurLocal;
            int idRelation = (int)Session.CreateQuery(requeteIdRelation).UniqueResult<int>();

            Relation relation = Session.Load<Relation>(idRelation);
            relation.Statut = "possede"; // màj des données

            Session.SaveOrUpdate(relation); // Màj d'une ligne dans la table Relation de la DB
            Session.Flush();
        }

        public void DeleteRelation(BD bdLocal, int idUtilisateurLocal, string statutLocal)
        {
            string titre = bdLocal.Titre;
            string auteur = bdLocal.Auteur;
            string requeteIdBD = "select Id from BD bd where bd.Titre='" + titre + "' and bd.Auteur='" + auteur + "'";
            int idBD = (int)Session.CreateQuery(requeteIdBD).UniqueResult<int>();

            string requeteIdRelation = "select Id from Relation r where r.BD=" + idBD +
                " and r.Personne=" + idUtilisateurLocal +
                " and r.Statut='" + statutLocal + "'";
            int idRelation = (int)Session.CreateQuery(requeteIdRelation).UniqueResult<int>();

            Relation relation = Session.Load<Relation>(idRelation);

            Session.Delete(relation); // Suppression d'une ligne dans la table Relation de la DB
            Session.Flush();
        }

    }
}
