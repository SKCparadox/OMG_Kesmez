namespace OMG_Kesmez
{
    partial class View
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labelZahl1 = new System.Windows.Forms.Label();
            this.labelZahl2 = new System.Windows.Forms.Label();
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.labelGGT = new System.Windows.Forms.Label();
            this.textBoxGGT = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GGTBerechnen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelZahl1
            // 
            this.labelZahl1.AutoSize = true;
            this.labelZahl1.Location = new System.Drawing.Point(12, 15);
            this.labelZahl1.Name = "labelZahl1";
            this.labelZahl1.Size = new System.Drawing.Size(37, 13);
            this.labelZahl1.TabIndex = 6;
            this.labelZahl1.Text = "Zahl 1";
            // 
            // labelZahl2
            // 
            this.labelZahl2.AutoSize = true;
            this.labelZahl2.Location = new System.Drawing.Point(12, 45);
            this.labelZahl2.Name = "labelZahl2";
            this.labelZahl2.Size = new System.Drawing.Size(37, 13);
            this.labelZahl2.TabIndex = 7;
            this.labelZahl2.Text = "Zahl 2";
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(55, 12);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(100, 20);
            this.textBoxZahl1.TabIndex = 8;
            // 
            // labelGGT
            // 
            this.labelGGT.AutoSize = true;
            this.labelGGT.Location = new System.Drawing.Point(12, 72);
            this.labelGGT.Name = "labelGGT";
            this.labelGGT.Size = new System.Drawing.Size(30, 13);
            this.labelGGT.TabIndex = 9;
            this.labelGGT.Text = "GGT";
            // 
            // textBoxGGT
            // 
            this.textBoxGGT.Location = new System.Drawing.Point(55, 72);
            this.textBoxGGT.Name = "textBoxGGT";
            this.textBoxGGT.Size = new System.Drawing.Size(100, 20);
            this.textBoxGGT.TabIndex = 10;
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(55, 38);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(100, 20);
            this.textBoxZahl2.TabIndex = 11;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 141);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxGGT);
            this.Controls.Add(this.labelGGT);
            this.Controls.Add(this.textBoxZahl1);
            this.Controls.Add(this.labelZahl2);
            this.Controls.Add(this.labelZahl1);
            this.Controls.Add(this.button1);
            this.Name = "View";
            this.Text = "OMG_Kesmez";
            this.Load += new System.EventHandler(this.View_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelZahl1;
        private System.Windows.Forms.Label labelZahl2;
        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.Label labelGGT;
        private System.Windows.Forms.TextBox textBoxGGT;
        private System.Windows.Forms.TextBox textBoxZahl2;
    }
}

