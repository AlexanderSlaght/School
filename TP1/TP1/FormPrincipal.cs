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

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        //Functions----------------------------------------------------------------------------

        public void UpdateBindingSourceWithList()
        {
            ListeDeStagiaire.stagiaires = new List<Stagiaire>();
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(1, "Alexander", "44444", "a@gmail.com", new List<Stage> { new Stage("hello", DateTime.Today, DateTime.Today, "evil", "He fucked a goat on his first shift."), new Stage("bye", DateTime.Today, DateTime.Today, "boring", "Despite killing himself after the third break his work was well done!") }));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(2, "Jean-Phillipe", "44444", "a@gmail.com", new List<Stage> { }));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(3, "Sam", "44444", "a@gmail.com", new List<Stage> { }));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com", new List<Stage> { }));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com", new List<Stage> { }));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com", new List<Stage> { }));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com", new List<Stage> { }));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com", new List<Stage> { }));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com", new List<Stage> { }));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com", new List<Stage> { }));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com", new List<Stage> { }));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com", new List<Stage> { }));
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(4, "CokieMonster", "44444", "a@gmail.com", new List<Stage> { }));
            stagiaireBindingSource.DataSource = ListeDeStagiaire.stagiaires;
        }

        private void AjouterStageAuFichierXML(string stageString)
        {
            //Ajouter le string au fichier XML
            throw new NotImplementedException();
        }

        //Il faut aussi considerer la validation des dates
        private bool VerificationDuGroupeBoxStage()
        {
            if (string.IsNullOrEmpty(this.textBoxTitre.Text) ||
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
            nouveauStage.dateDebut = DateTime.Today;
            nouveauStage.dateFin = DateTime.Today;
            nouveauStage.nomSuperviseur = this.textBoxNomSuperviseur.Text;
            return nouveauStage;
        }

        private void ActiverStagiaireModifier()
        {
            foreach (Control ctrl in groupBoxStagiaire.Controls)
            {
                ctrl.Enabled = true;
            }
        }

        private void DesactiverStagiaireModifier()
        {
            foreach (Control ctrl in groupBoxStagiaire.Controls)
            {
                ctrl.Enabled = false;
            }
            textBoxNumero.Text = "";
            textBoxNom.Text = "";
            textBoxTelephone.Text = "";
            textBoxCourriel.Text = "";
            stageBindingSource.DataSource = null;
            StagiaireSelecteur.stagiaireSel = null;
        }

        private void ActiverStageModifier()
        {
            foreach (Control ctrl in groupBoxStage.Controls)
            {
                ctrl.Enabled = true;
            }
            StageSelecteur.stageSel = null;
        }

        private void DesactiverStageModifier()
        {
            this.textBoxTitre.Text = "";
            this.textBoxNomSuperviseur.Text = "";
            this.textBoxCommentaire.Text = "";
            foreach (Control ctrl in groupBoxStage.Controls)
            {
                ctrl.Enabled = false;
            }
        }

        //Boutons Charger & Sauvegard----------------------------------------------------------------------------

        private void ButtonSauvegard_Click(object sender, EventArgs e)
        {

        }

        private void ButtonChargerXML_Click(object sender, EventArgs e)
        {
            ListeDeStagiaire.stagiaires = new List<Stagiaire>();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlDocument document = new XmlDocument();
                document.Load(openFileDialog.FileName);

                foreach (XmlNode node in document.DocumentElement)
                {
                    if (node.Name == "stagiaire")
                    {
                        //Construction du stagiaire
                        Stagiaire nouveauStagiaire = new Stagiaire();
                        nouveauStagiaire.numeroEmployee = 5;
                        //Convert.ToInt32(node.Attributes[0].InnerText);
                        nouveauStagiaire.nom = node.Attributes[1].InnerText;
                        nouveauStagiaire.numeroTelephone = node.Attributes[2].InnerText;
                        nouveauStagiaire.courriel = node.Attributes[3].InnerText;
                        List<Stage> nouvelleListeDeStage = new List<Stage>();
                        nouveauStagiaire.stage = nouvelleListeDeStage;
                        foreach (XmlNode child in document.ChildNodes)
                        {
                            if (node.Name == "stage")
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
                foreach (Stagiaire st in ListeDeStagiaire.stagiaires)
                {
                    Console.WriteLine("allo");
                }
                DesactiverStagiaireModifier();
                stagiaireBindingSource.DataSource = ListeDeStagiaire.stagiaires;
                dataGridStagiaire.Update();
                dataGridStagiaire.Refresh();



            }

        }

        //Boutons De Liste De Stagiaire----------------------------------------------------------------------------

        private void DataGridStagiaire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((Stagiaire)stagiaireBindingSource.Current != null)
            {
                DesactiverStageModifier();
                ActiverStagiaireModifier();
                Stagiaire stagiaireToModify = (Stagiaire)stagiaireBindingSource.Current;
                textBoxNumero.Text = stagiaireToModify.numeroEmployee.ToString();
                textBoxNom.Text = stagiaireToModify.nom;
                textBoxTelephone.Text = stagiaireToModify.numeroTelephone;
                textBoxCourriel.Text = stagiaireToModify.numeroTelephone;
                stageBindingSource.DataSource = new List<Stage>();
                foreach (Stage s in stagiaireToModify.stage)
                {
                    stageBindingSource.Add(s);
                }
                StagiaireSelecteur.stagiaireSel = stagiaireToModify;
            }
        }

        private void ButtonAjouterStagiaire_Click(object sender, EventArgs e)
        {
            DesactiverStageModifier();
            StagiaireSelecteur.stagiaireSel = null;
            stageBindingSource.DataSource = new List<Stage>();
            ActiverStagiaireModifier();
        }

        private void ButtonSupprimerStagiaire_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRechercher_Click(object sender, EventArgs e)
        {
            List<Stagiaire> resultatsRecherche = new List<Stagiaire>();
            bool bonResultat;
            foreach (Stagiaire i in ListeDeStagiaire.stagiaires)
            {
                bonResultat = false;
                string rech = textBoxRecherche.Text;
                if (i.nom.Contains(rech) || i.numeroEmployee.ToString().Contains(rech) || i.numeroEmployee.ToString().Contains(rech) ||
                    i.numeroTelephone.Contains(rech) || i.courriel.Contains(rech))
                {
                    bonResultat = true;
                }
                if (i.stage.Count > 0)
                {
                    foreach (Stage s in i.stage)
                    {
                        if (s.titre.Contains(rech) || s.nomSuperviseur.Contains(rech) || s.commentaire.Contains(rech))
                        {
                            bonResultat = true;
                        }
                    }
                }
                if (bonResultat == true)
                {
                    resultatsRecherche.Add(i);
                }

            }
            stagiaireBindingSource.DataSource = resultatsRecherche;
            dataGridStagiaire.Update();
            dataGridStagiaire.Refresh();
            buttonListeComplete.Enabled = true;

        }

        private void ButtonListeComplete_Click(object sender, EventArgs e)
        {
            buttonListeComplete.Enabled = false;
            stagiaireBindingSource.DataSource = ListeDeStagiaire.stagiaires;
            dataGridStagiaire.Update();
            dataGridStagiaire.Refresh();
        }

        //Boutons De Info De Stagiaire----------------------------------------------------------------------------

        private void DataGridStage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((Stage)stageBindingSource.Current != null)
            {
                ActiverStageModifier();
                Stage stageToModify = (Stage)stageBindingSource.Current;
                textBoxTitre.Text = stageToModify.titre;
                dateDateDebut.Value = stageToModify.dateDebut;
                dateDateFin.Value = stageToModify.dateFin;
                textBoxNomSuperviseur.Text = stageToModify.nomSuperviseur;
                textBoxCommentaire.Text = stageToModify.commentaire;
                StageSelecteur.stageSel = stageToModify;
            }

        }

        private void ButtonAjouterStage_Click(object sender, EventArgs e)
        {
            ActiverStageModifier();
        }

        private void ButtonSupprimerStage_Click(object sender, EventArgs e)
        {
            stageBindingSource.Remove(stageBindingSource.Current);
            dataGridStage.Update();
            dataGridStage.Refresh();
        }

        private void ButtonValistagiaire_Click(object sender, EventArgs e)
        {
            if (StagiaireSelecteur.stagiaireSel == null)
            {
                stagiaireBindingSource.Add(new Stagiaire(int.Parse(textBoxNumero.Text), textBoxNom.Text, textBoxTelephone.Text, textBoxCourriel.Text, (List<Stage>)stageBindingSource.DataSource));
                ListeDeStagiaire.stagiaires = (List<Stagiaire>)stagiaireBindingSource.DataSource;
            }
            else
            {
                StagiaireSelecteur.stagiaireSel.nom = textBoxNom.Text;
                StagiaireSelecteur.stagiaireSel.numeroEmployee = int.Parse(textBoxNumero.Text);
                StagiaireSelecteur.stagiaireSel.numeroTelephone = textBoxTelephone.Text;
                StagiaireSelecteur.stagiaireSel.courriel = textBoxCourriel.Text;
                StagiaireSelecteur.stagiaireSel.stage = (List<Stage>)stageBindingSource.DataSource;
            }
            DesactiverStagiaireModifier();
            dataGridStagiaire.Update();
            dataGridStagiaire.Refresh();

        }

        private void ButtonAnnulerStagiaire_Click(object sender, EventArgs e)
        {
            DialogResult validation = MessageBox.Show(
                            "Voulez-vous vraiment annuler l'ajout du nouveau stagiaire? " +
                            "Les renseignements seront perdus.",
                            "Attention!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

            if (validation is DialogResult.Yes)
            {
                DesactiverStagiaireModifier();
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

        //Boutons De Info Du Stage----------------------------------------------------------------------------

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            //A coder
            if (this.VerificationDuGroupeBoxStage())
            {
                //Stage nouveauStage = this.ConstruireNouveauStage();
                //AjouterStageAuFichierXML(nouveauStage.ToString());
                if (StageSelecteur.stageSel == null)
                {
                    stageBindingSource.Add(new Stage(textBoxTitre.Text, dateDateDebut.Value.Date, dateDateFin.Value.Date, textBoxNomSuperviseur.Text, textBoxCommentaire.Text));
                }
                else
                {
                    StageSelecteur.stageSel.titre = textBoxTitre.Text;
                    StageSelecteur.stageSel.dateDebut = dateDateDebut.Value;
                    StageSelecteur.stageSel.dateFin = dateDateFin.Value;
                    StageSelecteur.stageSel.nomSuperviseur = textBoxNomSuperviseur.Text;
                    StageSelecteur.stageSel.commentaire = textBoxCommentaire.Text;
                }
                dataGridStage.Update();
                dataGridStage.Refresh();
                foreach (Control ctrl in groupBoxStage.Controls)
                {
                    ctrl.Enabled = false;
                }
                this.textBoxTitre.Text = "";
                this.textBoxNomSuperviseur.Text = "";
                this.textBoxCommentaire.Text = "";
            }


            Console.WriteLine($"{this.dateDateDebut}");

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
                DesactiverStageModifier();
            }
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

        
    }
}
