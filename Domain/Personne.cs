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

        public Personne() { }
        public Personne(int id, string login, string mdp)
        {
            Id = id;
            Login = login;
            Mdp = mdp;
        }
        public override string ToString()
        {
            return Login;
        }
    }
}
