using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;

namespace TP1
{
    public class Stage
    {
        private string m_titre;
        public string titre
        {
            get
            {
                return this.m_titre;
            }
            set
            {
                Debug.Assert(string.IsNullOrEmpty(value));
                this.m_titre = value;
            }
        }

        private DateTime m_dateDebut;
        public DateTime dateDebut
        {
            get
            {
                return this.m_dateDebut;
            }
            set
            {
                this.m_dateDebut = value;
            }
        }

        private DateTime m_dateFin;
        public DateTime dateFin
        {
            get
            {
                return this.m_dateFin;
            }
            set
            {
                this.m_dateFin = value;
            }
        }

        private string m_nomSuperviseur;
        public string nomSuperviseur
        {
            get
            {
                return this.m_nomSuperviseur;
            }
            set
            {
                Debug.Assert(string.IsNullOrEmpty(value));
                this.m_nomSuperviseur = value;
            }
        }

        private string m_commentaire;

        public string commentaire
        {
            get
            {
                return this.m_commentaire;
            }
            set
            {
                this.m_commentaire = value;
            }
        }

        public Stage()
        {
            this.m_titre = "";
            this.m_dateDebut = DateTime.Today;
            this.m_dateFin = DateTime.Today;
            this.m_nomSuperviseur = "";
            this.m_commentaire = "";
        }

        public Stage(string p_titre, DateTime p_dateDebut, DateTime p_dateFin, string p_nomSuper, string p_comment)
        {
            this.m_titre = p_titre;
            this.m_dateDebut = p_dateDebut;
            this.m_dateFin = p_dateFin;
            this.m_nomSuperviseur = p_nomSuper;
            this.m_commentaire = p_comment;
        }

        public override string ToString()
        {
            string stageString = $"\t<stage " +
                                        $"titre=\"{this.titre}\"" +
                                        $"dateDebut=\"{this.dateDebut}\"" +
                                        $"dateFin=\"{this.dateFin}\"" +
                                        $"nomSuperviseur=\"{this.nomSuperviseur}\"" +
                                        $"commentaire=\"{this.commentaire}\"";
            return stageString;
        }
    }
}
