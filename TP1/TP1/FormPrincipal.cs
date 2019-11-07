using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
