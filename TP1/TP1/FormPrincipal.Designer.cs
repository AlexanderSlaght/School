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
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.buttonListeComplete = new System.Windows.Forms.Button();
            this.dataGridStagiaire = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stagiaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSupprimerStagiaire = new System.Windows.Forms.Button();
            this.buttonAjouterStagiaire = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.groupBoxStagiaire = new System.Windows.Forms.GroupBox();
            this.dataGridStage = new System.Windows.Forms.DataGridView();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAnnulerStagiaire = new System.Windows.Forms.Button();
            this.buttonValistagiaire = new System.Windows.Forms.Button();
            this.buttonSupprimerStage = new System.Windows.Forms.Button();
            this.buttonAjouterStage = new System.Windows.Forms.Button();
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
            this.buttonChargerXML = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStagiaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireBindingSource)).BeginInit();
            this.groupBoxStagiaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBindingSource)).BeginInit();
            this.groupBoxStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxListe
            // 
            this.groupBoxListe.Controls.Add(this.buttonListeComplete);
            this.groupBoxListe.Controls.Add(this.dataGridStagiaire);
            this.groupBoxListe.Controls.Add(this.buttonSupprimerStagiaire);
            this.groupBoxListe.Controls.Add(this.buttonAjouterStagiaire);
            this.groupBoxListe.Controls.Add(this.buttonRechercher);
            this.groupBoxListe.Controls.Add(this.textBoxRecherche);
            this.groupBoxListe.Location = new System.Drawing.Point(16, 6);
            this.groupBoxListe.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxListe.Name = "groupBoxListe";
            this.groupBoxListe.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxListe.Size = new System.Drawing.Size(376, 480);
            this.groupBoxListe.TabIndex = 0;
            this.groupBoxListe.TabStop = false;
            this.groupBoxListe.Text = "Liste De Stagiaire";
            // 
            // buttonListeComplete
            // 
            this.buttonListeComplete.Enabled = false;
            this.buttonListeComplete.Location = new System.Drawing.Point(101, 407);
            this.buttonListeComplete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListeComplete.Name = "buttonListeComplete";
            this.buttonListeComplete.Size = new System.Drawing.Size(129, 24);
            this.buttonListeComplete.TabIndex = 26;
            this.buttonListeComplete.Text = "Afficher Liste Complète";
            this.buttonListeComplete.UseVisualStyleBackColor = true;
            this.buttonListeComplete.Click += new System.EventHandler(this.ButtonListeComplete_Click);
            // 
            // dataGridStagiaire
            // 
            this.dataGridStagiaire.AllowUserToAddRows = false;
            this.dataGridStagiaire.AllowUserToDeleteRows = false;
            this.dataGridStagiaire.AllowUserToResizeColumns = false;
            this.dataGridStagiaire.AllowUserToResizeRows = false;
            this.dataGridStagiaire.AutoGenerateColumns = false;
            this.dataGridStagiaire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStagiaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStagiaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.numeroEmployeeDataGridViewTextBoxColumn});
            this.dataGridStagiaire.DataSource = this.stagiaireBindingSource;
            this.dataGridStagiaire.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridStagiaire.Location = new System.Drawing.Point(6, 16);
            this.dataGridStagiaire.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridStagiaire.MultiSelect = false;
            this.dataGridStagiaire.Name = "dataGridStagiaire";
            this.dataGridStagiaire.ReadOnly = true;
            this.dataGridStagiaire.RowHeadersVisible = false;
            this.dataGridStagiaire.RowHeadersWidth = 51;
            this.dataGridStagiaire.RowTemplate.Height = 24;
            this.dataGridStagiaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStagiaire.Size = new System.Drawing.Size(270, 281);
            this.dataGridStagiaire.TabIndex = 25;
            this.dataGridStagiaire.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridStagiaire_CellClick);
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom :";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // numeroEmployeeDataGridViewTextBoxColumn
            // 
            this.numeroEmployeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroEmployeeDataGridViewTextBoxColumn.DataPropertyName = "numeroEmployee";
            this.numeroEmployeeDataGridViewTextBoxColumn.FillWeight = 65F;
            this.numeroEmployeeDataGridViewTextBoxColumn.HeaderText = "# d\'employé :";
            this.numeroEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroEmployeeDataGridViewTextBoxColumn.Name = "numeroEmployeeDataGridViewTextBoxColumn";
            this.numeroEmployeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroEmployeeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stagiaireBindingSource
            // 
            this.stagiaireBindingSource.DataSource = typeof(TP1.Stagiaire);
            // 
            // buttonSupprimerStagiaire
            // 
            this.buttonSupprimerStagiaire.Location = new System.Drawing.Point(196, 444);
            this.buttonSupprimerStagiaire.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSupprimerStagiaire.Name = "buttonSupprimerStagiaire";
            this.buttonSupprimerStagiaire.Size = new System.Drawing.Size(129, 23);
            this.buttonSupprimerStagiaire.TabIndex = 3;
            this.buttonSupprimerStagiaire.Text = "&Supprimer Stagiaire";
            this.buttonSupprimerStagiaire.UseVisualStyleBackColor = true;
            this.buttonSupprimerStagiaire.Click += new System.EventHandler(this.ButtonSupprimerStagiaire_Click);
            // 
            // buttonAjouterStagiaire
            // 
            this.buttonAjouterStagiaire.Location = new System.Drawing.Point(8, 444);
            this.buttonAjouterStagiaire.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAjouterStagiaire.Name = "buttonAjouterStagiaire";
            this.buttonAjouterStagiaire.Size = new System.Drawing.Size(135, 23);
            this.buttonAjouterStagiaire.TabIndex = 1;
            this.buttonAjouterStagiaire.Text = "&Ajouter Stagiaire";
            this.buttonAjouterStagiaire.UseVisualStyleBackColor = true;
            this.buttonAjouterStagiaire.Click += new System.EventHandler(this.ButtonAjouterStagiaire_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(268, 372);
            this.buttonRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(75, 23);
            this.buttonRechercher.TabIndex = 0;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.ButtonRechercher_Click);
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(8, 375);
            this.textBoxRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(189, 20);
            this.textBoxRecherche.TabIndex = 0;
            // 
            // groupBoxStagiaire
            // 
            this.groupBoxStagiaire.Controls.Add(this.dataGridStage);
            this.groupBoxStagiaire.Controls.Add(this.buttonAnnulerStagiaire);
            this.groupBoxStagiaire.Controls.Add(this.buttonValistagiaire);
            this.groupBoxStagiaire.Controls.Add(this.buttonSupprimerStage);
            this.groupBoxStagiaire.Controls.Add(this.buttonAjouterStage);
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
            // dataGridStage
            // 
            this.dataGridStage.AllowUserToAddRows = false;
            this.dataGridStage.AllowUserToDeleteRows = false;
            this.dataGridStage.AllowUserToResizeColumns = false;
            this.dataGridStage.AllowUserToResizeRows = false;
            this.dataGridStage.AutoGenerateColumns = false;
            this.dataGridStage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titreDataGridViewTextBoxColumn});
            this.dataGridStage.DataSource = this.stageBindingSource;
            this.dataGridStage.Enabled = false;
            this.dataGridStage.Location = new System.Drawing.Point(8, 138);
            this.dataGridStage.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridStage.MultiSelect = false;
            this.dataGridStage.Name = "dataGridStage";
            this.dataGridStage.ReadOnly = true;
            this.dataGridStage.RowHeadersVisible = false;
            this.dataGridStage.RowHeadersWidth = 51;
            this.dataGridStage.RowTemplate.Height = 24;
            this.dataGridStage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStage.Size = new System.Drawing.Size(256, 217);
            this.dataGridStage.TabIndex = 24;
            this.dataGridStage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridStage_CellClick);
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "Titre :";
            this.titreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            this.titreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stageBindingSource
            // 
            this.stageBindingSource.DataSource = typeof(TP1.Stage);
            // 
            // buttonAnnulerStagiaire
            // 
            this.buttonAnnulerStagiaire.Enabled = false;
            this.buttonAnnulerStagiaire.Location = new System.Drawing.Point(143, 406);
            this.buttonAnnulerStagiaire.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnulerStagiaire.Name = "buttonAnnulerStagiaire";
            this.buttonAnnulerStagiaire.Size = new System.Drawing.Size(121, 23);
            this.buttonAnnulerStagiaire.TabIndex = 23;
            this.buttonAnnulerStagiaire.Text = "&Annuler";
            this.buttonAnnulerStagiaire.UseVisualStyleBackColor = true;
            this.buttonAnnulerStagiaire.Click += new System.EventHandler(this.ButtonAnnulerStagiaire_Click);
            // 
            // buttonValistagiaire
            // 
            this.buttonValistagiaire.Enabled = false;
            this.buttonValistagiaire.Location = new System.Drawing.Point(9, 406);
            this.buttonValistagiaire.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValistagiaire.Name = "buttonValistagiaire";
            this.buttonValistagiaire.Size = new System.Drawing.Size(123, 23);
            this.buttonValistagiaire.TabIndex = 23;
            this.buttonValistagiaire.Text = "&Valider";
            this.buttonValistagiaire.UseVisualStyleBackColor = true;
            this.buttonValistagiaire.Click += new System.EventHandler(this.ButtonValistagiaire_Click);
            // 
            // buttonSupprimerStage
            // 
            this.buttonSupprimerStage.Enabled = false;
            this.buttonSupprimerStage.Location = new System.Drawing.Point(191, 452);
            this.buttonSupprimerStage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSupprimerStage.Name = "buttonSupprimerStage";
            this.buttonSupprimerStage.Size = new System.Drawing.Size(111, 23);
            this.buttonSupprimerStage.TabIndex = 4;
            this.buttonSupprimerStage.Text = "&Supprimer Stage";
            this.buttonSupprimerStage.UseVisualStyleBackColor = true;
            this.buttonSupprimerStage.Click += new System.EventHandler(this.ButtonSupprimerStage_Click);
            // 
            // buttonAjouterStage
            // 
            this.buttonAjouterStage.Enabled = false;
            this.buttonAjouterStage.Location = new System.Drawing.Point(20, 452);
            this.buttonAjouterStage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAjouterStage.Name = "buttonAjouterStage";
            this.buttonAjouterStage.Size = new System.Drawing.Size(117, 23);
            this.buttonAjouterStage.TabIndex = 4;
            this.buttonAjouterStage.Text = "&Ajouter Stage";
            this.buttonAjouterStage.UseVisualStyleBackColor = true;
            this.buttonAjouterStage.Click += new System.EventHandler(this.ButtonAjouterStage_Click);
            // 
            // labelStages
            // 
            this.labelStages.AutoSize = true;
            this.labelStages.Location = new System.Drawing.Point(6, 122);
            this.labelStages.Name = "labelStages";
            this.labelStages.Size = new System.Drawing.Size(46, 13);
            this.labelStages.TabIndex = 8;
            this.labelStages.Text = "Stages :";
            // 
            // labelCourriel
            // 
            this.labelCourriel.AutoSize = true;
            this.labelCourriel.Location = new System.Drawing.Point(6, 97);
            this.labelCourriel.Name = "labelCourriel";
            this.labelCourriel.Size = new System.Drawing.Size(48, 13);
            this.labelCourriel.TabIndex = 7;
            this.labelCourriel.Text = "Courriel :";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(6, 71);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(107, 13);
            this.labelTelephone.TabIndex = 6;
            this.labelTelephone.Text = "Numero Telephone  :";
            // 
            // textBoxCourriel
            // 
            this.textBoxCourriel.Enabled = false;
            this.textBoxCourriel.Location = new System.Drawing.Point(159, 116);
            this.textBoxCourriel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCourriel.Name = "textBoxCourriel";
            this.textBoxCourriel.Size = new System.Drawing.Size(146, 20);
            this.textBoxCourriel.TabIndex = 5;
            this.textBoxCourriel.TextChanged += new System.EventHandler(this.TextBoxCourriel_TextChanged);
            this.textBoxCourriel.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCourriel_Validating);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Enabled = false;
            this.textBoxTelephone.Location = new System.Drawing.Point(159, 84);
            this.textBoxTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(146, 20);
            this.textBoxTelephone.TabIndex = 4;
            this.textBoxTelephone.TextChanged += new System.EventHandler(this.TextBoxTelephone_TextChanged);
            this.textBoxTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxTelephone_Validating);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Enabled = false;
            this.textBoxNom.Location = new System.Drawing.Point(159, 52);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(146, 20);
            this.textBoxNom.TabIndex = 3;
            this.textBoxNom.TextChanged += new System.EventHandler(this.TextBoxNom_TextChanged);
            this.textBoxNom.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNom_Validating);
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Enabled = false;
            this.textBoxNumero.Location = new System.Drawing.Point(159, 20);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(146, 20);
            this.textBoxNumero.TabIndex = 2;
            this.textBoxNumero.TextChanged += new System.EventHandler(this.TextBoxNumero_TextChanged);
            this.textBoxNumero.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNumero_Validating);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(6, 45);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom :";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(6, 19);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(100, 13);
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
            this.buttonAnnuler.Enabled = false;
            this.buttonAnnuler.Location = new System.Drawing.Point(142, 396);
            this.buttonAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(123, 23);
            this.buttonAnnuler.TabIndex = 22;
            this.buttonAnnuler.Text = "&Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.Enabled = false;
            this.buttonValider.Location = new System.Drawing.Point(9, 396);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(123, 23);
            this.buttonValider.TabIndex = 21;
            this.buttonValider.Text = "&Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // dateDateFin
            // 
            this.dateDateFin.Enabled = false;
            this.dateDateFin.Location = new System.Drawing.Point(119, 68);
            this.dateDateFin.Margin = new System.Windows.Forms.Padding(2);
            this.dateDateFin.Name = "dateDateFin";
            this.dateDateFin.Size = new System.Drawing.Size(146, 20);
            this.dateDateFin.TabIndex = 20;
            this.dateDateFin.ValueChanged += new System.EventHandler(this.DateDateFin_ValueChanged);
            this.dateDateFin.Validating += new System.ComponentModel.CancelEventHandler(this.DateDateFin_Validating);
            // 
            // dateDateDebut
            // 
            this.dateDateDebut.Enabled = false;
            this.dateDateDebut.Location = new System.Drawing.Point(119, 42);
            this.dateDateDebut.Margin = new System.Windows.Forms.Padding(2);
            this.dateDateDebut.Name = "dateDateDebut";
            this.dateDateDebut.Size = new System.Drawing.Size(146, 20);
            this.dateDateDebut.TabIndex = 19;
            this.dateDateDebut.ValueChanged += new System.EventHandler(this.DateDateDebut_ValueChanged);
            this.dateDateDebut.Validating += new System.ComponentModel.CancelEventHandler(this.DateDateDebut_Validating);
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Enabled = false;
            this.textBoxCommentaire.Location = new System.Drawing.Point(12, 170);
            this.textBoxCommentaire.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(256, 238);
            this.textBoxCommentaire.TabIndex = 18;
            this.textBoxCommentaire.Text = "";
            this.textBoxCommentaire.TextChanged += new System.EventHandler(this.TextBoxCommentaire_TextChanged);
            this.textBoxCommentaire.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCommentaire_Validating);
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Location = new System.Drawing.Point(6, 122);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(74, 13);
            this.labelCommentaire.TabIndex = 17;
            this.labelCommentaire.Text = "Commentaire :";
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Location = new System.Drawing.Point(6, 19);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(34, 13);
            this.labelTitre.TabIndex = 9;
            this.labelTitre.Text = "Titre :";
            // 
            // labelNomSuperviseur
            // 
            this.labelNomSuperviseur.AutoSize = true;
            this.labelNomSuperviseur.Location = new System.Drawing.Point(6, 97);
            this.labelNomSuperviseur.Name = "labelNomSuperviseur";
            this.labelNomSuperviseur.Size = new System.Drawing.Size(107, 13);
            this.labelNomSuperviseur.TabIndex = 16;
            this.labelNomSuperviseur.Text = "Nom du superviseur :";
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Location = new System.Drawing.Point(6, 45);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(68, 13);
            this.labelDateDebut.TabIndex = 10;
            this.labelDateDebut.Text = "Date Debut :";
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Location = new System.Drawing.Point(6, 71);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(56, 13);
            this.labelDateFin.TabIndex = 15;
            this.labelDateFin.Text = "Date Fin  :";
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Enabled = false;
            this.textBoxTitre.Location = new System.Drawing.Point(159, 20);
            this.textBoxTitre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(146, 20);
            this.textBoxTitre.TabIndex = 11;
            this.textBoxTitre.TextChanged += new System.EventHandler(this.TextBoxTitre_TextChanged);
            this.textBoxTitre.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxTitre_Validating);
            // 
            // textBoxNomSuperviseur
            // 
            this.textBoxNomSuperviseur.Enabled = false;
            this.textBoxNomSuperviseur.Location = new System.Drawing.Point(159, 116);
            this.textBoxNomSuperviseur.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomSuperviseur.Name = "textBoxNomSuperviseur";
            this.textBoxNomSuperviseur.Size = new System.Drawing.Size(146, 20);
            this.textBoxNomSuperviseur.TabIndex = 14;
            this.textBoxNomSuperviseur.TextChanged += new System.EventHandler(this.TextBoxNomSuperviseur_TextChanged);
            // 
            // buttonSauvegard
            // 
            this.buttonSauvegard.Location = new System.Drawing.Point(212, 494);
            this.buttonSauvegard.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSauvegard.Name = "buttonSauvegard";
            this.buttonSauvegard.Size = new System.Drawing.Size(135, 43);
            this.buttonSauvegard.TabIndex = 4;
            this.buttonSauvegard.Text = "&Sauvegarder Information";
            this.buttonSauvegard.UseVisualStyleBackColor = true;
            this.buttonSauvegard.Click += new System.EventHandler(this.ButtonSauvegard_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // buttonChargerXML
            // 
            this.buttonChargerXML.Location = new System.Drawing.Point(16, 494);
            this.buttonChargerXML.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChargerXML.Name = "buttonChargerXML";
            this.buttonChargerXML.Size = new System.Drawing.Size(135, 43);
            this.buttonChargerXML.TabIndex = 5;
            this.buttonChargerXML.Text = "&Charger Fichier XML";
            this.buttonChargerXML.UseVisualStyleBackColor = true;
            this.buttonChargerXML.Click += new System.EventHandler(this.ButtonChargerXML_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xml";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "xml file |*.xml| text file |*.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            // 
            // FormPrincipal
            // 
            this.AcceptButton = this.buttonValistagiaire;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1162, 547);
            this.Controls.Add(this.buttonChargerXML);
            this.Controls.Add(this.buttonSauvegard);
            this.Controls.Add(this.groupBoxStage);
            this.Controls.Add(this.groupBoxStagiaire);
            this.Controls.Add(this.groupBoxListe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de stages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.groupBoxListe.ResumeLayout(false);
            this.groupBoxListe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStagiaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stagiaireBindingSource)).EndInit();
            this.groupBoxStagiaire.ResumeLayout(false);
            this.groupBoxStagiaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stageBindingSource)).EndInit();
            this.groupBoxStage.ResumeLayout(false);
            this.groupBoxStage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListe;
        private System.Windows.Forms.GroupBox groupBoxStagiaire;
        private System.Windows.Forms.GroupBox groupBoxStage;
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
        private System.Windows.Forms.Button buttonAjouterStage;
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
        private System.Windows.Forms.Button buttonAnnulerStagiaire;
        private System.Windows.Forms.Button buttonValistagiaire;
        private System.Windows.Forms.Button buttonChargerXML;
        private System.Windows.Forms.DataGridView dataGridStagiaire;
        private System.Windows.Forms.DataGridView dataGridStage;
        private System.Windows.Forms.BindingSource stagiaireBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stageBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonListeComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

