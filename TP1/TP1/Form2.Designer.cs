namespace TP1
{
    partial class ChargerXML
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonNouvelleListe = new System.Windows.Forms.Button();
            this.buttonModifierListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(12, 19);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(279, 13);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Voulez-vous créer une nouvelle liste ou modifier une liste?";
            // 
            // buttonNouvelleListe
            // 
            this.buttonNouvelleListe.Location = new System.Drawing.Point(26, 45);
            this.buttonNouvelleListe.Name = "buttonNouvelleListe";
            this.buttonNouvelleListe.Size = new System.Drawing.Size(113, 23);
            this.buttonNouvelleListe.TabIndex = 1;
            this.buttonNouvelleListe.Text = "Nouvelle liste";
            this.buttonNouvelleListe.UseVisualStyleBackColor = true;
            this.buttonNouvelleListe.Click += new System.EventHandler(this.ButtonNouvelleListe_Click);
            // 
            // buttonModifierListe
            // 
            this.buttonModifierListe.Location = new System.Drawing.Point(167, 45);
            this.buttonModifierListe.Name = "buttonModifierListe";
            this.buttonModifierListe.Size = new System.Drawing.Size(108, 23);
            this.buttonModifierListe.TabIndex = 2;
            this.buttonModifierListe.Text = "Modifier une liste";
            this.buttonModifierListe.UseVisualStyleBackColor = true;
            // 
            // ChargerXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 84);
            this.Controls.Add(this.buttonModifierListe);
            this.Controls.Add(this.buttonNouvelleListe);
            this.Controls.Add(this.labelQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChargerXML";
            this.Text = "Gestion De Stage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChargerXML_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonNouvelleListe;
        private System.Windows.Forms.Button buttonModifierListe;
    }
}