using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Utilisateur : Personne
    {
        public List<BD> Possessions { get; set; }
        public List<BD> Souhaits { get; set; }
        public Utilisateur(List<BD> possessions, List<BD> souhaits)
        {
            Possessions = possessions;
            Souhaits = souhaits;
        }
    }
}
