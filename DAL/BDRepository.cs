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
            int idUtilisateur = 1;
            return Session.CreateQuery("select * from bd as bd join relation.pers_id as id where id = idUtilisateur").List<BD>();
        }
        public void Save(BD bd)
        {
            Session.Save(bd);
        }
    }
}
