using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BD
    {
        public virtual int Id { get; set; }
        public virtual string Titre { get; set; }
        public virtual string Auteur { get; set; }
        public virtual string Dessinateur { get; set; }
        public virtual string Editeur { get; set; }
        public virtual string Serie { get; set; }
        public virtual string Genre { get; set; }
        public virtual string Couverture { get; set; }

        public BD() { }
        public BD(int id, string titre, string auteur, string dessinateur)
        {
            Id = id;
            Titre = titre;
            Auteur = auteur;
            Dessinateur = dessinateur;
        }
    }
}
