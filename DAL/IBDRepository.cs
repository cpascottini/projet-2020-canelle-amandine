using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IBDRepository
    {
        IList<BD> GetAll();
        IList<BD> GetBDUtilisateur();
        IList<BD> GetBDRecherche(string rechercheLocal);
        void Save(BD bd);
    }
}
