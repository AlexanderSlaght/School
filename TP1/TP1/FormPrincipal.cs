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
using System.Text.RegularExpressions;

namespace TP1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            AttacherBindingSourceaListe();
            IntialiserSuiveursEvenements();

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        //Functions----------------------------------------------------------------------------

        public void AttacherBindingSourceaListe()
        {
            ListeDeStagiaire.stagiaires = new List<Stagiaire>();

            /* Objets test
            ListeDeStagiaire.stagiaires.Add(new Stagiaire(1, "Alexander", "44444", "a@gmail.com", new List<Stage> { new Stage("hello", DateTime.Today, DateTime.Today, "evil", "He killed a goat on his first shift."), new Stage("bye", DateTime.Today, DateTime.Today, "boring", "Despite killing himself after the third break his work was well done!") }));
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
            */
            stagiaireBindingSource.DataSource = ListeDeStagiaire.stagiaires;
        }

        private void IntialiserSuiveursEvenements()
        {
            SuiveursEvenements.bonneEntreesStages = new bool[4];
            SuiveursEvenements.bonneEntreesStagiaires = new bool[4];
            SuiveursEvenements.nouveauxChangementsStage = false;
            SuiveursEvenements.nouveauxChangementsStagiaire = false;
            SuiveursEvenements.travailNonSauvegarde = true;
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
            SuiveursEvenements.nouveauxChangementsStagiaire = false;
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
            errorProvider.SetError(textBoxTitre, "");
            errorProvider.SetError(dateDateDebut, "");
            errorProvider.SetError(dateDateFin, "");
            errorProvider.SetError(textBoxCommentaire, "");
            dateDateDebut.Value = DateTime.Today;
            dateDateFin.Value = DateTime.Today;
            SuiveursEvenements.nouveauxChangementsStage = false;
        }

        //Boutons Charger & Sauvegard----------------------------------------------------------------------------

        private void ButtonSauvegard_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                XmlTextWriter xmlWriter = new XmlTextWriter(fileName, System.Text.Encoding.UTF8);
                xmlWriter.WriteStartDocument();

                //root node
                xmlWriter.WriteStartElement("stagiaires");
                foreach (Stagiaire stagiaire in ListeDeStagiaire.stagiaires)
                {
                    xmlWriter.WriteStartElement("stagiaire");
                    xmlWriter.WriteElementString("numeroEmploye", Convert.ToString(stagiaire.numeroEmployee));
                    xmlWriter.WriteElementString("nom", stagiaire.nom);
                    xmlWriter.WriteElementString("numeroTelephone", stagiaire.numeroTelephone);
                    xmlWriter.WriteElementString("courriel", stagiaire.courriel);

                    if (stagiaire.stage != null)
                    {
                        foreach (Stage st in stagiaire.stage)
                        {
                            xmlWriter.WriteStartElement("stage");
                            xmlWriter.WriteElementString("titre", st.titre);
                            xmlWriter.WriteElementString("dateDebut", st.dateDebut.ToString("dd-MM-yyyy"));
                            xmlWriter.WriteElementString("dateFin", st.dateFin.ToString("dd-MM-yyyy"));
                            xmlWriter.WriteElementString("nomSuperviseur", st.nomSuperviseur);
                            xmlWriter.WriteElementString("commentaire", st.commentaire);
                            //xmlWriter.WriteEndElement();
                        }
                    }
                    //xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Flush();
                xmlWriter.Close();
            }
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
                        Stagiaire nouveauStagiaire = new Stagiaire(
                            Convert.ToInt32(node.Attributes[0].InnerText),
                            node.Attributes[1].InnerText,
                            node.Attributes[2].InnerText,
                            node.Attributes[3].InnerText, 
                            p_listeStage : new List<Stage>());

                        foreach (XmlNode cNode in node.ChildNodes)
                        {

                            if (cNode.LocalName == "stage")
                            {
                                //Construction de la liste de stage du stagiaire
                                Stage nouveauStage = new Stage(
                                    cNode.Attributes[0].InnerText,
                                    DateTime.ParseExact(cNode.Attributes[1].InnerText, "dd-MM-yyyy", null),
                                    DateTime.ParseExact(cNode.Attributes[2].InnerText, "dd-MM-yyyy", null),
                                    cNode.Attributes[3].InnerText,
                                    cNode.Attributes[4].InnerText
                                    );
                                nouveauStagiaire.stage.Add(nouveauStage);
                            }
                        }
                        ListeDeStagiaire.stagiaires.Add(nouveauStagiaire);
                    }

                }

                DesactiverStagiaireModifier();
                DesactiverStageModifier();
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
                Stagiaire stagiaireAModifier = (Stagiaire)stagiaireBindingSource.Current;
                textBoxNumero.Text = stagiaireAModifier.numeroEmployee.ToString();
                textBoxNom.Text = stagiaireAModifier.nom;
                textBoxTelephone.Text = stagiaireAModifier.numeroTelephone;
                textBoxCourriel.Text = stagiaireAModifier.numeroTelephone;
                stageBindingSource.DataSource = new List<Stage>();
                foreach (Stage s in stagiaireAModifier.stage)
                {
                    stageBindingSource.Add(s);
                }
                StagiaireSelecteur.stagiaireSel = stagiaireAModifier;
                SuiveursEvenements.bonneEntreesStagiaires[0] = true;
                SuiveursEvenements.bonneEntreesStagiaires[1] = true;
                SuiveursEvenements.bonneEntreesStagiaires[2] = true;
                SuiveursEvenements.bonneEntreesStagiaires[3] = true;
            }
        }

        private void ButtonAjouterStagiaire_Click(object sender, EventArgs e)
        {
            DesactiverStageModifier();
            StagiaireSelecteur.stagiaireSel = null;
            stageBindingSource.DataSource = new List<Stage>();
            SuiveursEvenements.bonneEntreesStagiaires[0] = false;
            SuiveursEvenements.bonneEntreesStagiaires[1] = false;
            SuiveursEvenements.bonneEntreesStagiaires[2] = false;
            SuiveursEvenements.bonneEntreesStagiaires[3] = false;
            ActiverStagiaireModifier();
        }

        private void ButtonSupprimerStagiaire_Click(object sender, EventArgs e)
        {
            SuiveursEvenements.travailNonSauvegarde = true;
            stagiaireBindingSource.Remove(stagiaireBindingSource.Current);
            ListeDeStagiaire.stagiaires = (List<Stagiaire>)stagiaireBindingSource.DataSource;
            dataGridStage.Update();
            dataGridStage.Refresh();
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
                SuiveursEvenements.bonneEntreesStages[0] = true;
                SuiveursEvenements.bonneEntreesStages[1] = true;
                SuiveursEvenements.bonneEntreesStages[2] = true;
                SuiveursEvenements.bonneEntreesStages[3] = true;
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
            SuiveursEvenements.bonneEntreesStages[0] = false;
            SuiveursEvenements.bonneEntreesStages[1] = true;
            SuiveursEvenements.bonneEntreesStages[2] = false;
            SuiveursEvenements.bonneEntreesStages[3] = false;
        }

        private void ButtonSupprimerStage_Click(object sender, EventArgs e)
        {
            stageBindingSource.Remove(stageBindingSource.Current);
            dataGridStage.Update();
            dataGridStage.Refresh();
        }

        private void ButtonValistagiaire_Click(object sender, EventArgs e)
        {
            if (!SuiveursEvenements.bonneEntreesStagiaires[0] || !SuiveursEvenements.bonneEntreesStagiaires[1] 
                || !SuiveursEvenements.bonneEntreesStagiaires[2] || !SuiveursEvenements.bonneEntreesStagiaires[3])
            {
                if (!SuiveursEvenements.bonneEntreesStagiaires[0]) { this.errorProvider.SetError(textBoxNumero, "Le numero d'employe ne peut pas etre vide, plus de zero et unique."); }
                if (!SuiveursEvenements.bonneEntreesStagiaires[1]) { this.errorProvider.SetError(textBoxNom, "Le nom ne peut pas etre vide."); }
                if (!SuiveursEvenements.bonneEntreesStagiaires[2]) { this.errorProvider.SetError(textBoxTelephone, "Le numero de telephone doit avoir le format 123-456-7890"); }
                if (!SuiveursEvenements.bonneEntreesStagiaires[3]) { this.errorProvider.SetError(textBoxCourriel, "Le courriel ne doit pas etre vide."); }
            }
            else
            {
                if (StagiaireSelecteur.stagiaireSel == null)
                {
                    stagiaireBindingSource.Add(new Stagiaire(int.Parse(textBoxNumero.Text), textBoxNom.Text, textBoxTelephone.Text, 
                        textBoxCourriel.Text, (List<Stage>)stageBindingSource.DataSource));
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
                SuiveursEvenements.travailNonSauvegarde = true;
                DesactiverStageModifier();
                DesactiverStagiaireModifier();
                dataGridStagiaire.Update();
                dataGridStagiaire.Refresh();

            }
        }


        private void ButtonAnnulerStagiaire_Click(object sender, EventArgs e)
        {
            DialogResult validation = DialogResult.Yes;
            if (SuiveursEvenements.nouveauxChangementsStagiaire)
            {
                validation = MessageBox.Show(
                "Voulez-vous vraiment annuler l'ajout du nouveau stagiaire? " +
                "Les renseignements seront perdus.",
                "Attention!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            }
            if (validation is DialogResult.Yes)
            {
                DesactiverStagiaireModifier();
                DesactiverStageModifier();
                errorProvider.Clear();
            }
        }

        private void TextBoxNumero_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumero.Text))
            {
                SuiveursEvenements.bonneEntreesStagiaires[0] = false;
                e.Cancel = true;
                this.errorProvider.SetError(textBoxNumero, "Le numero d'employe ne peut pas etre vide.");
            }
            else if(!Int32.TryParse(this.textBoxNumero.Text, out int numEmp))
            {
                SuiveursEvenements.bonneEntreesStagiaires[0] = false;
                e.Cancel = true;
                this.errorProvider.SetError(textBoxNumero, "Le numero d'employe doit etre un nombre.");
            }
            else
            {
                int numeroEmployeTeste = int.Parse(this.textBoxNumero.Text);
                if(numeroEmployeTeste <= 0)
                {
                    SuiveursEvenements.bonneEntreesStagiaires[0] = false;
                    e.Cancel = true;
                    this.errorProvider.SetError(textBoxNumero, "Le numero d'employe doit etre supérieur à zéro.");
                }
                else
                {
                    bool numeroUnique = true;
                    foreach(Stagiaire s in ListeDeStagiaire.stagiaires)
                    {
                        if(s.numeroEmployee == numeroEmployeTeste)
                        {
                            numeroUnique = false;
                            break;
                        }
                    }
                    if (numeroUnique == false)
                    {
                        SuiveursEvenements.bonneEntreesStagiaires[0] = false;
                        e.Cancel = true;
                        this.errorProvider.SetError(textBoxNumero, "Le numero d'employe doit etre unique.");
                    }
                    else
                    {
                        SuiveursEvenements.bonneEntreesStagiaires[0] = true;
                        e.Cancel = false;
                        this.errorProvider.SetError(textBoxNumero, "");
                    }
                }
            }
        }

        private void TextBoxNom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNom.Text))
            {
                SuiveursEvenements.bonneEntreesStagiaires[1] = false;
                e.Cancel = true;
                this.errorProvider.SetError(textBoxNom, "Le nom ne peut pas etre vide.");
            }
            else
            {
                SuiveursEvenements.bonneEntreesStagiaires[1] = true;
                e.Cancel = false;
                this.errorProvider.SetError(textBoxNom, "");
            }
        }

        private void TextBoxTelephone_Validating(object sender, CancelEventArgs e)
        {
            Regex telephoneRegex = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
            if (!telephoneRegex.IsMatch(textBoxTelephone.Text))
            {
                SuiveursEvenements.bonneEntreesStagiaires[2] = false;
                e.Cancel = true;
                this.errorProvider.SetError(textBoxTelephone, "Le numero de telephone doit avoir le format 123-456-7890");
            }
            else
            {
                SuiveursEvenements.bonneEntreesStagiaires[2] = true;
                e.Cancel = false;
                this.errorProvider.SetError(textBoxTelephone, "");
            }
        }

        private void TextBoxCourriel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCourriel.Text))
            {
                SuiveursEvenements.bonneEntreesStagiaires[3] = false;
                e.Cancel = true;
                this.errorProvider.SetError(textBoxCourriel, "Le courriel ne doit pas etre vide.");
            }
            else
            {
                SuiveursEvenements.bonneEntreesStagiaires[3] = true;
                e.Cancel = false;
                this.errorProvider.SetError(textBoxCourriel, "");
            }
        }

        //Boutons De Info Du Stage----------------------------------------------------------------------------

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            if ( !SuiveursEvenements.bonneEntreesStages[0] || !SuiveursEvenements.bonneEntreesStages[1] 
                || !SuiveursEvenements.bonneEntreesStages[2] || !SuiveursEvenements.bonneEntreesStages[3])
            {
                if (!SuiveursEvenements.bonneEntreesStages[0]) { this.errorProvider.SetError(textBoxTitre, "Le champs titre ne doit pas etre vide."); }
                if (!SuiveursEvenements.bonneEntreesStages[1]) { this.errorProvider.SetError(dateDateDebut, 
                    "La première date du stage ne peut pas être antérieure à la date de création de l'entreprise. (1990-06-01)"); }
                if (!SuiveursEvenements.bonneEntreesStages[2]) { this.errorProvider.SetError(dateDateFin,
                        "Le dernier jour du stage ne peut être supérieur à un an à partir du premier jour.."); }
                if (!SuiveursEvenements.bonneEntreesStages[3]) { this.errorProvider.SetError(textBoxCommentaire, "Le commentaire ne peut être trop long."); }
            }
            else
            {
                if (this.VerificationDuGroupeBoxStage())
                {
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
                    errorProvider.Clear();
                }
            }

        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult validation = DialogResult.Yes;
            if (SuiveursEvenements.nouveauxChangementsStagiaire)
            {
                validation = MessageBox.Show(
                    "Voulez-vous vraiment annuler l'ajout du nouveau stage? " +
                    "Les renseignements seront perdus.",
                    "Attention!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            }
            if (validation is DialogResult.Yes)
            {
                DesactiverStageModifier();
            }

        }

        private void TextBoxTitre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxTitre.Text))
            {
                SuiveursEvenements.bonneEntreesStages[0] = false;
                e.Cancel = true;
                this.errorProvider.SetError(textBoxTitre,
                    "Le champs titre ne doit pas etre vide.");
            }
            else
            {
                SuiveursEvenements.bonneEntreesStages[0] = true;
                e.Cancel = false;
                this.errorProvider.SetError(textBoxTitre, "");
            }
        }

        private void DateDateDebut_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateFondation = new DateTime(1990, 06, 01);
            if (dateDateDebut.Value < dateFondation)
            {
                SuiveursEvenements.bonneEntreesStages[1] = false;
                e.Cancel = true;
                this.errorProvider.SetError(dateDateDebut,
                    "La première date du stage ne peut pas être antérieure à la date de création de l'entreprise. (1990-06-01)");
            }
            else
            {
                SuiveursEvenements.bonneEntreesStages[1] = true;
                e.Cancel = false;
                this.errorProvider.SetError(dateDateDebut, "");
            }
        }

        private void DateDateFin_Validating(object sender, CancelEventArgs e)
        {
            if (dateDateFin.Value <= dateDateDebut.Value)
            {
                SuiveursEvenements.bonneEntreesStages[2] = false;
                e.Cancel = true;
                this.errorProvider.SetError(dateDateFin,
                    "Le dernier jour de stage ne peut pas être avant le premier.");
            }
            else
            {
                if (dateDateFin.Value > dateDateDebut.Value.AddYears(1))
                {
                    SuiveursEvenements.bonneEntreesStages[2] = false;
                    e.Cancel = true;
                    this.errorProvider.SetError(dateDateFin,
                        "Le dernier jour du stage ne peut être supérieur à un an à partir du premier jour..");
                }
                else
                {
                    SuiveursEvenements.bonneEntreesStages[2] = true;
                    e.Cancel = false;
                    this.errorProvider.SetError(dateDateFin, "");
                }
            }
        }

        private void TextBoxCommentaire_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBoxCommentaire.Text.Length > 600)
            {
                SuiveursEvenements.bonneEntreesStages[3] = false;
                e.Cancel = true;
                this.errorProvider.SetError(textBoxCommentaire,
                    "Le commentaire ne peut être trop long.");
            }
            else
            {
                SuiveursEvenements.bonneEntreesStages[3] = true;
                e.Cancel = false;
                this.errorProvider.SetError(textBoxCommentaire, "");
            }
        }

        private void TextBoxTitre_TextChanged(object sender, EventArgs e)
        {
            SuiveursEvenements.nouveauxChangementsStage = true;
        }

        private void DateDateDebut_ValueChanged(object sender, EventArgs e)
        {
            SuiveursEvenements.nouveauxChangementsStage = true;
        }

        private void DateDateFin_ValueChanged(object sender, EventArgs e)
        {
            SuiveursEvenements.nouveauxChangementsStage = true;
        }

        private void TextBoxNomSuperviseur_TextChanged(object sender, EventArgs e)
        {
            SuiveursEvenements.nouveauxChangementsStage = true;
        }

        private void TextBoxCommentaire_TextChanged(object sender, EventArgs e)
        {
            SuiveursEvenements.nouveauxChangementsStage = true;
        }

        private void TextBoxNumero_TextChanged(object sender, EventArgs e)
        {
            SuiveursEvenements.nouveauxChangementsStagiaire = true;
        }

        private void TextBoxNom_TextChanged(object sender, EventArgs e)
        {
            SuiveursEvenements.nouveauxChangementsStagiaire = true;
        }

        private void TextBoxTelephone_TextChanged(object sender, EventArgs e)
        {
            SuiveursEvenements.nouveauxChangementsStagiaire = true;
        }

        private void TextBoxCourriel_TextChanged(object sender, EventArgs e)
        {
            SuiveursEvenements.nouveauxChangementsStagiaire = true;
        }
    }
}
