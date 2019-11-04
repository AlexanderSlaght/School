using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Stagiaire
    {
        public int numeroEmployee {get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string numeroTelephone { get; set; }
        public string courriel { get; set; }
        public List<Stage> stages { get; set; }

        public Stagiaire()
        {
            this.numeroEmployee = 0;
            this.nom = "";
            this.prenom = "";
            this.numeroTelephone = "";
            this.courriel = "";
            this.nom = "";
            this.stages = new List<Stage>();
        }
    }
}

