using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Le titre ne peut pas etre nul ou vide.");
                }
                else
                {
                    this.m_titre = value;
                }
            }
        }

        private DateTimePicker m_dateDebut;
        public DateTimePicker dateDebut
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

        private DateTimePicker m_dateFin;
        public DateTimePicker dateFin
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Le nom du superviseur ne peut pas etre nul ou vide.");
                }
                else
                {
                    this.m_nomSuperviseur = value;
                }
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
            this.m_dateDebut = null;
            this.m_dateFin = null;
            this.m_nomSuperviseur = "";
            this.m_commentaire = "";
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
