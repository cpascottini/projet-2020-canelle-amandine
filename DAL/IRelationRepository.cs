using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IRelationRepository
    {
        IList<Relation> GetAll();
        void SaveRelation(BD bdLocal, int idUtilisateurLocal, string statut);
        void UpdateRelation(BD bdLocal, int idUtilisateurLocal);
        void DeleteRelation(BD bdLocal, int idUtilisateur, string statutLocal);
    }
}
