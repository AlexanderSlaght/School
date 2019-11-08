using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public static class SuiveursEvenements
    {
        public static bool[] bonneEntreesStagiaires { get; set; }
        public static bool[] bonneEntreesStages { get; set; }
        public static bool nouveauxChangementsStage { get; set; }
        public static bool nouveauxChangementsStagiaire { get; set; }
        public static bool travailNonSauvegarde { get; set; }
    }
}
