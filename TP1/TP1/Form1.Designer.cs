namespace TP1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxListe = new System.Windows.Forms.GroupBox();
            this.buttonSupprimerStagiaire = new System.Windows.Forms.Button();
            this.buttonModifierStagiaire = new System.Windows.Forms.Button();
            this.buttonAjouterStagiaire = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.listBoxstagiaire = new System.Windows.Forms.ListBox();
            this.groupBoxStagiaire = new System.Windows.Forms.GroupBox();
            this.buttonSupprimerStage = new System.Windows.Forms.Button();
            this.buttonModifierStage = new System.Windows.Forms.Button();
            this.buttonAjouterStage = new System.Windows.Forms.Button();
            this.listBoxStages = new System.Windows.Forms.ListBox();
            this.labelStages = new System.Windows.Forms.Label();
            this.labelCourriel = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.textBoxCourriel = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.groupBoxStage = new System.Windows.Forms.GroupBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.dateDateFin = new System.Windows.Forms.DateTimePicker();
            this.dateDateDebut = new System.Windows.Forms.DateTimePicker();
            this.textBoxCommentaire = new System.Windows.Forms.RichTextBox();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelNomSuperviseur = new System.Windows.Forms.Label();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.textBoxNomSuperviseur = new System.Windows.Forms.TextBox();
            this.buttonSauvegard = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxListe.SuspendLayout();
            this.groupBoxStagiaire.SuspendLayout();
            this.groupBoxStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListe
            // 
            this.groupBoxListe.Controls.Add(this.buttonSupprimerStagiaire);
            this.groupBoxListe.Controls.Add(this.buttonModifierStagiaire);
            this.groupBoxListe.Controls.Add(this.buttonAjouterStagiaire);
            this.groupBoxListe.Controls.Add(this.buttonRechercher);
            this.groupBoxListe.Controls.Add(this.textBoxRecherche);
            this.groupBoxListe.Controls.Add(this.listBoxstagiaire);
            this.groupBoxListe.Location = new System.Drawing.Point(16, 6);
            this.groupBoxListe.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxListe.Name = "groupBoxListe";
            this.groupBoxListe.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxListe.Size = new System.Drawing.Size(376, 480);
            this.groupBoxListe.TabIndex = 0;
            this.groupBoxListe.TabStop = false;
            this.groupBoxListe.Text = "Liste De Stagiaire";
            // 
            // buttonSupprimerStagiaire
            // 
            this.buttonSupprimerStagiaire.Location = new System.Drawing.Point(101, 439);
            this.buttonSupprimerStagiaire.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSupprimerStagiaire.Name = "buttonSupprimerStagiaire";
            this.buttonSupprimerStagiaire.Size = new System.Drawing.Size(172, 28);
            this.buttonSupprimerStagiaire.TabIndex = 3;
            this.buttonSupprimerStagiaire.Text = "&Supprimer Stagiaire";
            this.buttonSupprimerStagiaire.UseVisualStyleBackColor = true;
            // 
            // buttonModifierStagiaire
            // 
            this.buttonModifierStagiaire.Location = new System.Drawing.Point(196, 404);
            this.buttonModifierStagiaire.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModifierStagiaire.Name = "buttonModifierStagiaire";
            this.buttonModifierStagiaire.Size = new System.Drawing.Size(172, 28);
            this.buttonModifierStagiaire.TabIndex = 2;
            this.buttonModifierStagiaire.Text = "&Modifier Stagiaire";
            this.buttonModifierStagiaire.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterStagiaire
            // 
            this.buttonAjouterStagiaire.Location = new System.Drawing.Point(8, 404);
            this.buttonAjouterStagiaire.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAjouterStagiaire.Name = "buttonAjouterStagiaire";
            this.buttonAjouterStagiaire.Size = new System.Drawing.Size(180, 28);
            this.buttonAjouterStagiaire.TabIndex = 1;
            this.buttonAjouterStagiaire.Text = "&Ajouter Stagiaire";
            this.buttonAjouterStagiaire.UseVisualStyleBackColor = true;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(268, 369);
            this.buttonRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(100, 28);
            this.buttonRechercher.TabIndex = 0;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(8, 372);
            this.textBoxRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(251, 22);
            this.textBoxRecherche.TabIndex = 0;
            // 
            // listBoxstagiaire
            // 
            this.listBoxstagiaire.FormattingEnabled = true;
            this.listBoxstagiaire.ItemHeight = 16;
            this.listBoxstagiaire.Location = new System.Drawing.Point(8, 23);
            this.listBoxstagiaire.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxstagiaire.Name = "listBoxstagiaire";
            this.listBoxstagiaire.Size = new System.Drawing.Size(359, 340);
            this.listBoxstagiaire.TabIndex = 0;
            // 
            // groupBoxStagiaire
            // 
            this.groupBoxStagiaire.Controls.Add(this.buttonSupprimerStage);
            this.groupBoxStagiaire.Controls.Add(this.buttonModifierStage);
            this.groupBoxStagiaire.Controls.Add(this.buttonAjouterStage);
            this.groupBoxStagiaire.Controls.Add(this.listBoxStages);
            this.groupBoxStagiaire.Controls.Add(this.labelStages);
            this.groupBoxStagiaire.Controls.Add(this.labelCourriel);
            this.groupBoxStagiaire.Controls.Add(this.labelTelephone);
            this.groupBoxStagiaire.Controls.Add(this.textBoxCourriel);
            this.groupBoxStagiaire.Controls.Add(this.textBoxTelephone);
            this.groupBoxStagiaire.Controls.Add(this.textBoxNom);
            this.groupBoxStagiaire.Controls.Add(this.textBoxNumero);
            this.groupBoxStagiaire.Controls.Add(this.labelNom);
            this.groupBoxStagiaire.Controls.Add(this.labelNumero);
            this.groupBoxStagiaire.Location = new System.Drawing.Point(400, 6);
            this.groupBoxStagiaire.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStagiaire.Name = "groupBoxStagiaire";
            this.groupBoxStagiaire.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStagiaire.Size = new System.Drawing.Size(376, 540);
            this.groupBoxStagiaire.TabIndex = 1;
            this.groupBoxStagiaire.TabStop = false;
            this.groupBoxStagiaire.Text = "Info du Stagiaire";
            // 
            // buttonSupprimerStage
            // 
            this.buttonSupprimerStage.Location = new System.Drawing.Point(105, 506);
            this.buttonSupprimerStage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSupprimerStage.Name = "buttonSupprimerStage";
            this.buttonSupprimerStage.Size = new System.Drawing.Size(172, 28);
            this.buttonSupprimerStage.TabIndex = 4;
            this.buttonSupprimerStage.Text = "&Supprimer Stage";
            this.buttonSupprimerStage.UseVisualStyleBackColor = true;
            // 
            // buttonModifierStage
            // 
            this.buttonModifierStage.Location = new System.Drawing.Point(196, 470);
            this.buttonModifierStage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModifierStage.Name = "buttonModifierStage";
            this.buttonModifierStage.Size = new System.Drawing.Size(172, 28);
            this.buttonModifierStage.TabIndex = 4;
            this.buttonModifierStage.Text = "&Modifier Stage";
            this.buttonModifierStage.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterStage
            // 
            this.buttonAjouterStage.Location = new System.Drawing.Point(12, 470);
            this.buttonAjouterStage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAjouterStage.Name = "buttonAjouterStage";
            this.buttonAjouterStage.Size = new System.Drawing.Size(180, 28);
            this.buttonAjouterStage.TabIndex = 4;
            this.buttonAjouterStage.Text = "&Ajouter Stage";
            this.buttonAjouterStage.UseVisualStyleBackColor = true;
            this.buttonAjouterStage.Click += new System.EventHandler(this.ButtonAjouterStage_Click);
            // 
            // listBoxStages
            // 
            this.listBoxStages.FormattingEnabled = true;
            this.listBoxStages.ItemHeight = 16;
            this.listBoxStages.Location = new System.Drawing.Point(12, 170);
            this.listBoxStages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxStages.Name = "listBoxStages";
            this.listBoxStages.Size = new System.Drawing.Size(355, 292);
            this.listBoxStages.TabIndex = 4;
            // 
            // labelStages
            // 
            this.labelStages.AutoSize = true;
            this.labelStages.Location = new System.Drawing.Point(8, 150);
            this.labelStages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStages.Name = "labelStages";
            this.labelStages.Size = new System.Drawing.Size(60, 17);
            this.labelStages.TabIndex = 8;
            this.labelStages.Text = "Stages :";
            // 
            // labelCourriel
            // 
            this.labelCourriel.AutoSize = true;
            this.labelCourriel.Location = new System.Drawing.Point(8, 119);
            this.labelCourriel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCourriel.Name = "labelCourriel";
            this.labelCourriel.Size = new System.Drawing.Size(65, 17);
            this.labelCourriel.TabIndex = 7;
            this.labelCourriel.Text = "Courriel :";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(8, 87);
            this.labelTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(142, 17);
            this.labelTelephone.TabIndex = 6;
            this.labelTelephone.Text = "Numero Telephone  :";
            // 
            // textBoxCourriel
            // 
            this.textBoxCourriel.Location = new System.Drawing.Point(159, 116);
            this.textBoxCourriel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCourriel.Name = "textBoxCourriel";
            this.textBoxCourriel.Size = new System.Drawing.Size(208, 22);
            this.textBoxCourriel.TabIndex = 5;
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(159, 84);
            this.textBoxTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(208, 22);
            this.textBoxTelephone.TabIndex = 4;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(159, 52);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(208, 22);
            this.textBoxNom.TabIndex = 3;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(159, 20);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(208, 22);
            this.textBoxNumero.TabIndex = 2;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(8, 55);
            this.labelNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(45, 17);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom :";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(8, 23);
            this.labelNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(134, 17);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Numero d\'employé :";
            // 
            // groupBoxStage
            // 
            this.groupBoxStage.Controls.Add(this.buttonAnnuler);
            this.groupBoxStage.Controls.Add(this.buttonValider);
            this.groupBoxStage.Controls.Add(this.dateDateFin);
            this.groupBoxStage.Controls.Add(this.dateDateDebut);
            this.groupBoxStage.Controls.Add(this.textBoxCommentaire);
            this.groupBoxStage.Controls.Add(this.labelCommentaire);
            this.groupBoxStage.Controls.Add(this.labelTitre);
            this.groupBoxStage.Controls.Add(this.labelNomSuperviseur);
            this.groupBoxStage.Controls.Add(this.labelDateDebut);
            this.groupBoxStage.Controls.Add(this.labelDateFin);
            this.groupBoxStage.Controls.Add(this.textBoxTitre);
            this.groupBoxStage.Controls.Add(this.textBoxNomSuperviseur);
            this.groupBoxStage.Location = new System.Drawing.Point(784, 6);
            this.groupBoxStage.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxStage.Name = "groupBoxStage";
            this.groupBoxStage.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxStage.Size = new System.Drawing.Size(376, 540);
            this.groupBoxStage.TabIndex = 2;
            this.groupBoxStage.TabStop = false;
            this.groupBoxStage.Text = "Info du Stage";
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(195, 488);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(172, 28);
            this.buttonAnnuler.TabIndex = 22;
            this.buttonAnnuler.Text = "&Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(12, 488);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(172, 28);
            this.buttonValider.TabIndex = 21;
            this.buttonValider.Text = "&Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // dateDateFin
            // 
            this.dateDateFin.Enabled = false;
            this.dateDateFin.Location = new System.Drawing.Point(159, 84);
            this.dateDateFin.Name = "dateDateFin";
            this.dateDateFin.Size = new System.Drawing.Size(208, 22);
            this.dateDateFin.TabIndex = 20;
            // 
            // dateDateDebut
            // 
            this.dateDateDebut.Enabled = false;
            this.dateDateDebut.Location = new System.Drawing.Point(159, 52);
            this.dateDateDebut.Name = "dateDateDebut";
            this.dateDateDebut.Size = new System.Drawing.Size(208, 22);
            this.dateDateDebut.TabIndex = 19;
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Enabled = false;
            this.textBoxCommentaire.Location = new System.Drawing.Point(12, 170);
            this.textBoxCommentaire.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(355, 292);
            this.textBoxCommentaire.TabIndex = 18;
            this.textBoxCommentaire.Text = "";
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Location = new System.Drawing.Point(8, 150);
            this.labelCommentaire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(99, 17);
            this.labelCommentaire.TabIndex = 17;
            this.labelCommentaire.Text = "Commentaire :";
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(8, 23);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(45, 17);
            this.labelTitre.TabIndex = 9;
            this.labelTitre.Text = "Titre :";
            // 
            // labelNomSuperviseur
            // 
            this.labelNomSuperviseur.AutoSize = true;
            this.labelNomSuperviseur.Location = new System.Drawing.Point(8, 119);
            this.labelNomSuperviseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomSuperviseur.Name = "labelNomSuperviseur";
            this.labelNomSuperviseur.Size = new System.Drawing.Size(143, 17);
            this.labelNomSuperviseur.TabIndex = 16;
            this.labelNomSuperviseur.Text = "Nom du superviseur :";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Location = new System.Drawing.Point(8, 55);
            this.labelDateDebut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(88, 17);
            this.labelDateDebut.TabIndex = 10;
            this.labelDateDebut.Text = "Date Debut :";
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Location = new System.Drawing.Point(8, 87);
            this.labelDateFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(73, 17);
            this.labelDateFin.TabIndex = 15;
            this.labelDateFin.Text = "Date Fin  :";
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Enabled = false;
            this.textBoxTitre.Location = new System.Drawing.Point(159, 20);
            this.textBoxTitre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(208, 22);
            this.textBoxTitre.TabIndex = 11;
            this.textBoxTitre.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxTitre_Validating);
            // 
            // textBoxNomSuperviseur
            // 
            this.textBoxNomSuperviseur.Enabled = false;
            this.textBoxNomSuperviseur.Location = new System.Drawing.Point(159, 116);
            this.textBoxNomSuperviseur.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomSuperviseur.Name = "textBoxNomSuperviseur";
            this.textBoxNomSuperviseur.Size = new System.Drawing.Size(208, 22);
            this.textBoxNomSuperviseur.TabIndex = 14;
            this.textBoxNomSuperviseur.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNomSuperviseur_Validating);
            // 
            // buttonSauvegard
            // 
            this.buttonSauvegard.Location = new System.Drawing.Point(16, 494);
            this.buttonSauvegard.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSauvegard.Name = "buttonSauvegard";
            this.buttonSauvegard.Size = new System.Drawing.Size(376, 53);
            this.buttonSauvegard.TabIndex = 4;
            this.buttonSauvegard.Text = "&Sauvegarder Information";
            this.buttonSauvegard.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 554);
            this.Controls.Add(this.buttonSauvegard);
            this.Controls.Add(this.groupBoxStage);
            this.Controls.Add(this.groupBoxStagiaire);
            this.Controls.Add(this.groupBoxListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Gestion de stages";
            this.groupBoxListe.ResumeLayout(false);
            this.groupBoxListe.PerformLayout();
            this.groupBoxStagiaire.ResumeLayout(false);
            this.groupBoxStagiaire.PerformLayout();
            this.groupBoxStage.ResumeLayout(false);
            this.groupBoxStage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListe;
        private System.Windows.Forms.ListBox listBoxstagiaire;
        private System.Windows.Forms.GroupBox groupBoxStagiaire;
        private System.Windows.Forms.GroupBox groupBoxStage;
        private System.Windows.Forms.Button buttonModifierStagiaire;
        private System.Windows.Forms.Button buttonAjouterStagiaire;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Button buttonSupprimerStagiaire;
        private System.Windows.Forms.Label labelStages;
        private System.Windows.Forms.Label labelCourriel;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.TextBox textBoxCourriel;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Button buttonSauvegard;
        private System.Windows.Forms.Button buttonSupprimerStage;
        private System.Windows.Forms.Button buttonModifierStage;
        private System.Windows.Forms.Button buttonAjouterStage;
        private System.Windows.Forms.ListBox listBoxStages;
        private System.Windows.Forms.RichTextBox textBoxCommentaire;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelNomSuperviseur;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.TextBox textBoxNomSuperviseur;
        private System.Windows.Forms.DateTimePicker dateDateFin;
        private System.Windows.Forms.DateTimePicker dateDateDebut;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

