using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Relation
    {
        public virtual int IdRelation { get; set;}
        public virtual int PersonneRelation { get; set; }
        public virtual int BDRelation { get; set; }
        public virtual string Statut { get; set; }

        public Relation() { }
    }
}
