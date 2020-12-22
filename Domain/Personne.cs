using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Personne
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Mdp { get; set; }
        public virtual string Role { get; set; }

        // spécifique à l'utilisateur
        public virtual ISet<BD> Possessions { get; set; }
        public virtual ISet<BD> Souhaits { get; set; }

        public Personne() { }
        public Personne(int id, string login, string mdp, string role)
        // pour construire un administrateur
        {
            Id = id;
            Login = login;
            Mdp = mdp;
            Role = role;
        }

        public Personne(int id, string login, string mdp, string role, ISet<BD> possessions, ISet<BD> souhaits)
        // pour construire un utilisateur
        {
            Id = id;
            Login = login;
            Mdp = mdp;
            Role = role;
            Possessions = possessions;
            Souhaits = souhaits;
        }
        public override string ToString()
        {
            return Login;
        }
    }
}