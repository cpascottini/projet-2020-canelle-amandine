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
        public void SaveRelation(BD bdLocal, int idUtilisateurLocal)
        {
            // màj des données
            Relation relation = new Relation();

            string requeteNbRelations = "select count(*) from Relation"; // Nb total de relations
            int nbRelations = (int)Session.CreateQuery(requeteNbRelations).UniqueResult<long>();
            relation.Id = nbRelations + 1;

            string titre = bdLocal.Titre;
            string auteur = bdLocal.Auteur;
            string requeteIdBD = "select Id from BD bd where bd.Titre='" + titre + "' and bd.Auteur='" + auteur + "'";
            int idBD = (int)Session.CreateQuery(requeteIdBD).UniqueResult<int>();
            relation.BD = idBD;

            relation.Personne = idUtilisateurLocal;
            relation.Statut = "possede";

            Session.SaveOrUpdate(relation); // Ajout d’une ligne dans la table Relation de la BD
        }
    }
}
