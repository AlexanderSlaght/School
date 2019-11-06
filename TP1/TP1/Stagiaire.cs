using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace TP1
{
    public class Stagiaire
    {
        private int m_numeroEmployee;
        public int numeroEmployee
        {
            get
            {
                return this.m_numeroEmployee;
            }
            set
            {

                this.m_numeroEmployee = value;
            }
        }

        private string m_nom;
        public string nom
        {
            get
            {
                return this.m_nom;
            }
            set
            {
                Debug.Assert(!string.IsNullOrEmpty(value));
                this.m_nom = value;
            }
        }

        private string m_numeroTelephone;
        public string numeroTelephone
        {
            get
            {
                return this.m_numeroTelephone;
            }
            set
            {
                Debug.Assert(!string.IsNullOrEmpty(value));
                Debug.Assert(!VerificationRegexTelephone(value));
                this.m_numeroTelephone = value;
            }
        }

        private string m_courriel;
        public string courriel
        {
            get
            {
                return this.m_courriel;
            }
            set
            {
                Debug.Assert(!string.IsNullOrEmpty(value));
                this.m_courriel = value;
            }
        }

        private List<Stage> m_stage;
        public List<Stage> stage
        {
            get
            {
                return this.m_stage;
            }
            set
            {
                this.m_stage = value;
            }
        }

        public Stagiaire()
        {
            this.numeroEmployee = 0;
            this.nom = "";
            this.numeroTelephone = "000-000-0000";
            this.courriel = "";
            this.stage = new List<Stage>();
        }

        public Stagiaire(int p_numEmploy, string p_nom, string p_numTele, string p_courriel)
        {
            this.numeroEmployee = p_numEmploy;
            this.nom = p_nom;
            this.numeroTelephone = p_numTele;
            this.courriel = p_courriel;
            this.stage = new List<Stage>();
        }

        public override string ToString()
        {
            string stagiaireString = $"<stagiaire " +
                                         $"numeroEmploye=\"{this.numeroEmployee}\">" +
                                         $"numeroEmploye=\"{this.nom}\">" +
                                         $"numeroEmploye=\"{this.numeroTelephone}\">" +
                                         $"numeroEmploye=\"{this.courriel}\">";
            return stagiaireString;
        }

        private bool VerificationRegexTelephone(string p_value)
        {
            Regex telephoneRegex = new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
            if (telephoneRegex.IsMatch(p_value))
            {
                return true;
            }
            return false;
        }
    }
}

