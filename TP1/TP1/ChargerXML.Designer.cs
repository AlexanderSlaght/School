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
            this.labelQuestion.Location = new System.Drawing.Point(74, 21);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(262, 17);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Voulez-vous créer ou modifier une liste?";
            // 
            // buttonNouvelleListe
            // 
            this.buttonNouvelleListe.Location = new System.Drawing.Point(49, 53);
            this.buttonNouvelleListe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNouvelleListe.Name = "buttonNouvelleListe";
            this.buttonNouvelleListe.Size = new System.Drawing.Size(151, 28);
            this.buttonNouvelleListe.TabIndex = 1;
            this.buttonNouvelleListe.Text = "Nouvelle liste";
            this.buttonNouvelleListe.UseVisualStyleBackColor = true;
            this.buttonNouvelleListe.Click += new System.EventHandler(this.ButtonNouvelleListe_Click);
            // 
            // buttonModifierListe
            // 
            this.buttonModifierListe.Location = new System.Drawing.Point(208, 53);
            this.buttonModifierListe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonModifierListe.Name = "buttonModifierListe";
            this.buttonModifierListe.Size = new System.Drawing.Size(144, 28);
            this.buttonModifierListe.TabIndex = 2;
            this.buttonModifierListe.Text = "Modifier une liste";
            this.buttonModifierListe.UseVisualStyleBackColor = true;
            // 
            // ChargerXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 103);
            this.Controls.Add(this.buttonModifierListe);
            this.Controls.Add(this.buttonNouvelleListe);
            this.Controls.Add(this.labelQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChargerXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion De Stage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChargerXML_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChargerXML_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonNouvelleListe;
        private System.Windows.Forms.Button buttonModifierListe;
    }
}