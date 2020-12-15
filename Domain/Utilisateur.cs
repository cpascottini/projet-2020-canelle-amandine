using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Utilisateur : Personne
    {
        public List<BD> Possessions;
        public List<BD> Souhaits;
    }
}
