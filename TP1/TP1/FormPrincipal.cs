using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace TP1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            UpdateBindingSourceWithList();
        }

        public void UpdateBindingSourceWithList()
        {
            ListeDeStagiaire.stagiaires = new List<Stagiaire>();
            /*
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(1, "Alexander", "44444", "a@gmail.com"));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(2, "Jean-Phillipe", "44444", "a@gmail.com"));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(3, "Sam", "44444", "a@gmail.com"));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com"));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com"));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com"));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com"));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com"));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com"));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com"));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com"));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com"));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com"));
            */
            foreach (Stagiaire n in ListeDeStagiaire.stagiaires)
            {
                stagiaireBindingSource.Add(n);
            }
        }

        private void ButtonAjouterStage_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupBoxStage.Controls)
            {
                ctrl.Enabled = true;
            }
        }

        private void TextBoxNumero_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumero.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxNumero, "Le numero d'employe ne peut pas etre vide.");
            }
            else if(!Int32.TryParse(this.textBoxNumero.Text, out int numEmp))
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxNumero, "Le numero d'employe doit etre un nombre.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void TextBoxNom_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TextBoxTelephone_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TextBoxCourriel_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TextBoxTitre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxTitre.Text))
            {
                e.Cancel = true;
                this.errorProvider.SetError(textBoxTitre,
                    "Le champs titre ne doit pas etre vide.");
            }
            else
            {
                e.Cancel = false;
                this.errorProvider.Clear();
            }
        }

        private void TextBoxNomSuperviseur_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxNomSuperviseur.Text))
            {
                e.Cancel = true;
                this.errorProvider.SetError(textBoxNomSuperviseur,
                    "Le nom du superviseur ne doit pas etre vide");
            }
            else
            {
                e.Cancel = false;
                this.errorProvider.Clear();
            }
        }

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            //A coder
            if (this.VerificationDuGroupeBoxStage())
            {
                Stage nouveauStage = this.ConstruireNouveauStage();
                AjouterStageAuFichierXML(nouveauStage.ToString());

                foreach (Control ctrl in groupBoxStage.Controls)
                {
                    ctrl.Enabled = false;
                }
                this.textBoxTitre.Text = "";
                this.textBoxNomSuperviseur.Text = "";
            }


            Console.WriteLine($"{this.dateDateDebut}");

        }

        private void AjouterStageAuFichierXML(string stageString)
        {
            //Ajouter le string au fichier XML
            throw new NotImplementedException();
        }

        //Il faut aussi considerer la validation des dates
        private bool VerificationDuGroupeBoxStage()
        {
            if(string.IsNullOrEmpty(this.textBoxTitre.Text) ||
               string.IsNullOrEmpty(this.textBoxNomSuperviseur.Text))
            {
                return false;
            }
            return true;
        }

        private Stage ConstruireNouveauStage()
        {
            Stage nouveauStage = new Stage();
            nouveauStage.titre = this.textBoxTitre.Text;
            nouveauStage.dateDebut = null;
            nouveauStage.dateFin = null;
            nouveauStage.nomSuperviseur = this.textBoxNomSuperviseur.Text;
            return nouveauStage;
        }


        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult validation = MessageBox.Show(
                            "Voulez-vous vraiment annuler l'ajout du nouveau stage? " +
                            "Les renseignements seront perdus.", 
                            "Attention!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

            if (validation is DialogResult.Yes)
            {
                this.textBoxTitre.Text = "";
                this.textBoxNomSuperviseur.Text = "";
                foreach(Control ctrl in groupBoxStage.Controls)
                {
                    ctrl.Enabled = false;
                }
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonModifierStagiaire_Click(object sender, EventArgs e)
        {

        }

        private void ButtonChargerXML_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlDocument document = new XmlDocument();
                document.Load(openFileDialog.FileName);

                foreach(XmlNode node in document.DocumentElement)
                {
                    if(node.Name == "stagiaire")
                    {
                        //Construction du stagiaire
                        Stagiaire nouveauStagiaire = new Stagiaire();
                        nouveauStagiaire.numeroEmployee = Convert.ToInt32(node.Attributes[0].InnerText);
                        nouveauStagiaire.nom = node.Attributes[1].InnerText;
                        nouveauStagiaire.numeroTelephone = node.Attributes[2].InnerText;
                        nouveauStagiaire.courriel = node.Attributes[3].InnerText;
                        List<Stage> nouvelleListeDeStage = new List<Stage>();
                        nouveauStagiaire.stage = nouvelleListeDeStage;
                        foreach(XmlNode child in document.ChildNodes)
                        {
                            if(node.Name == "stage")
                            {
                                //Construction de la liste de stage du stagiaire
                                Stage nouveauStage = new Stage();
                                nouveauStage.titre = node.Attributes[0].InnerText;
                                //Il faut convertir les string du document XML en dates valides (format datetimepicker)
                                //nouveauStage.dateDebut = node.Attributes[1].InnerText;
                                //nouveauStage.dateFin = node.Attributes[2].InnerText;
                                nouveauStage.nomSuperviseur = node.Attributes[3].InnerText;
                                nouveauStage.commentaire = node.Attributes[4].InnerText;
                                nouvelleListeDeStage.Add(nouveauStage);
                            }
                        }
                        ListeDeStagiaire.stagiaires.Add(nouveauStagiaire);
                    }

                }
                //juste pour verifier le nombre de stagiaire qui a ete ajouter a la liste. (to be deleted)
                foreach(Stagiaire st in ListeDeStagiaire.stagiaires)
                {
                    Console.WriteLine("allo");
                }
                
            }

        }
    }
}
