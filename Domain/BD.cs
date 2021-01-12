﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BD
    {
        public virtual int IdBD { get; set; }
        public virtual string Titre { get; set; }
        public virtual string Auteur { get; set; }
        public virtual string Dessinateur { get; set; }
        public virtual string Editeur { get; set; }
        public virtual string Serie { get; set; }
        public virtual string Genre { get; set; }
        public virtual string Couverture { get; set; }

        public BD() { }
        public BD(int id,
            string titre,
            string auteur,
            string dessinateur,
            string editeur,
            string serie,
            string genre,
            string couverture)
        {
            IdBD = id;
            Titre = titre;
            Auteur = auteur;
            Dessinateur = dessinateur;
            Editeur = editeur;
            Serie = serie;
            Genre = genre;
            Couverture = couverture;
        }

        public virtual string[] Decrire()
        {
            return new string[] { Serie, Titre, Auteur, Dessinateur };
        }

        public virtual string[] DecrireBDMarche(bool possede, bool veut)
        {
            
            return new string[] { Serie, Titre, Auteur, Dessinateur, possede.ToString(), veut.ToString() };
        }
    }
}