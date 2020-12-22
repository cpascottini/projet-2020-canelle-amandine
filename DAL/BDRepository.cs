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
            //return Session.CreateQuery("select bd_titre,bd_auteur,bd_dessinateur,bd_editeur,bd_serie,bd_genre,bd_couverture from BD, relation where relation.pers_id = 3 and BD.Id = relation.bd_id and relation.rel_statut = 'possede'").List<BD>();
            return Session.CreateQuery("select b from BD b").List<BD>();
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
