using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class ListeDeStagiaire
    {
        public List<Stagiaire> stagiaires { get; set; }

        public ListeDeStagiaire()
        {
            this.stagiaires = new List<Stagiaire>();
        }
    }
}
