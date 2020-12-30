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
        IList<BD> GetBDUtilisateur(int idUtilisateurLocal);
        IList<BD> GetBDWishlist(int idUtilisateurLocal);
        IList<BD> GetBDRecherche(string rechercheLocal);
        IList<BD> GetBDRow(string titreLocal, string auteurLocal);
        void AjouterBD(BD bdLocal, int idUtilisateurLocal);
        void Save(BD bd);
    }
}
