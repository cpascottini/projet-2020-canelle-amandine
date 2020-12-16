using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Personne
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Mdp { get; set; }
        public virtual string Statut { get; set; }

        // spécifique à l'utilisateur
        public virtual List<BD> Possessions { get; set; }
        public virtual List<BD> Souhaits { get; set; }

        public Personne() { }
        public Personne(int id, string login, string mdp, string statut)
        // pour construire un administrateur
        {
            Id = id;
            Login = login;
            Mdp = mdp;
            Statut = statut;
        }

        public Personne(int id, string login, string mdp, string statut, List<BD> possessions, List<BD> souhaits)
        // pour construire un utilisateur
        {
            Id = id;
            Login = login;
            Mdp = mdp;
            Statut = statut;
            Possessions = possessions;
            Souhaits = souhaits;
        }
        public override string ToString()
        {
            return Login;
        }
    }
}