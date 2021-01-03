﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IRelationRepository
    {
        List<Relation> GetAll();
        void SaveRelation(BD bdLocal, int idUtilisateurLocal, string statut);
    }
}
