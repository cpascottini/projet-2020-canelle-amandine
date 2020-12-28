using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Relation
    {
        public virtual int Id { get; set;}
        
        public virtual int Personne { get; set; }

        public virtual int BD { get; set; }

        public virtual string Statut { get; set; }
    }
}
