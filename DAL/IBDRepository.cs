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
        IList<BD> GetBDUtilisateur(int idUtilisateurLocal, string statut);
        IList<BD> GetBDRecherche(string rechercheLocal);
        IList<BD> GetBDRow(string titreLocal, string auteurLocal);
        void SaveBD(string titreLocal, string auteurLocal, string dessinateurLocal, string editeurLocal,
            string genreLocal, string couvertureLocal, string serieLocal, int numSerieLocal, string categorieLocal); // BD qui fait partie d'une série
        void SaveBD(string titreLocal, string auteurLocal, string dessinateurLocal, string editeurLocal,
           string genreLocal, string couvertureLocal, string categorieLocal); // BD qui ne fait pas partie d'une série

    }
}
