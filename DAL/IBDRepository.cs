﻿using System;
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
        void SaveBD(string titreLocal, string auteurLocal, string dessinateurLocal, string editeurLocal,
            string genreLocal, string couvertureLocal, string serieLocal); // BD qui fait partie d'une série
        void SaveBD(string titreLocal, string auteurLocal, string dessinateurLocal, string editeurLocal,
           string genreLocal, string couvertureLocal); // BD qui ne fait pas partie d'une série

    }
}
