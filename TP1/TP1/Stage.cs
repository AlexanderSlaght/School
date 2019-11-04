using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Stage
    {
        public string titre { get; set; }
        public string dateDebut { get; set; }
        public string dateFin { get; set; }
        public string nomSuperviseur { get; set; }
        public string commentaire { get; set; }

        public Stage()
        {
            this.titre = "";
            this.dateDebut = "";
            this.dateFin = "";
            this.nomSuperviseur = "";
            this.commentaire = "";
        }
    }
}
