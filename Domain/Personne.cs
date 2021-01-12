using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Personne
    {
        public virtual int IdPersonne { get; set; }
        public virtual string Login { get; set; }
        public virtual string Mdp { get; set; }
        public virtual string Role { get; set; }


        public Personne() { }

        public Personne(int id, string login, string mdp, string role)
        {
            IdPersonne = id;
            Login = login;
            Mdp = mdp;
            Role = role;
        }
    }
}