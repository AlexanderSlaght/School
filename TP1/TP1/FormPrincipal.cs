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
        }

        private void ButtonAjouterStage_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupBoxStage.Controls)
            {
                ctrl.Enabled = true;
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

        private void ButtonValider_Click(object sender, EventArgs e)
        {
            //A coder
            foreach (Control ctrl in groupBoxStage.Controls)
            {
                ctrl.Enabled = true;
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
