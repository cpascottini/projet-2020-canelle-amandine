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
        public void SaveRelation(BD bdLocal, int idUtilisateurLocal, string statut)
        {
            // màj des données
            Relation relation = new Relation();

            string titre = bdLocal.Titre;
            string auteur = bdLocal.Auteur;
            string requeteIdBD = "select Id from BD bd where bd.Titre='" + titre + "' and bd.Auteur='" + auteur + "'";
            int idBD = (int)Session.CreateQuery(requeteIdBD).UniqueResult<int>();
            relation.BD = idBD;

            relation.Personne = idUtilisateurLocal;
            relation.Statut = statut;

            Session.SaveOrUpdate(relation); // Ajout d’une ligne dans la table Relation de la BD
        }
    }
}
