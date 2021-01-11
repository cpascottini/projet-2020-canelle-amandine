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
            int idBD = GetIdBD(titre, auteur);
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
            int idBD = GetIdBD(titre, auteur);

            int idRelation = GetIdRelation(idBD, idUtilisateurLocal, "veut");

            Relation relation = Session.Load<Relation>(idRelation); // récupération de la relation correspondante
            relation.Statut = "possede"; // màj des données

            Session.SaveOrUpdate(relation); // Màj d'une ligne dans la table Relation de la DB
            Session.Flush();
        }

        public void DeleteRelation(BD bdLocal, int idUtilisateurLocal, string statutLocal)
        {
            string titre = bdLocal.Titre;
            string auteur = bdLocal.Auteur;
            int idBD = GetIdBD(titre, auteur);

            int idRelation = GetIdRelation(idBD,idUtilisateurLocal,statutLocal);

            Relation relation = Session.Load<Relation>(idRelation); // récupération de la relation correspondante

            Session.Delete(relation); // Suppression d'une ligne dans la table Relation de la DB
            Session.Flush();
        }

        private int GetIdBD(string titre, string auteur)
        {
            return (int)Session.CreateQuery("select IdBD from BD bd where bd.Titre=:titre and bd.Auteur=:auteur").SetString("titre", titre).SetString("auteur", auteur).UniqueResult<int>();
        }

        private int GetIdRelation(int idBD, int idUtilisateur, string statut)
        {
            return (int)Session.CreateQuery("select IdRelation from Relation r where r.BD =:bd and r.Personne=:personne and r.Statut=:statut").SetInt32("bd",idBD).SetInt32("personne", idUtilisateur).SetString("statut", statut).UniqueResult<int>();
        }
    }
}
