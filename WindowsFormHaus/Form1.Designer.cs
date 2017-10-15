namespace WindowsFormHaus
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNeuerMieter = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAnzahl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuszug = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupBoxWohneinheit = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.textBoxGroesse = new System.Windows.Forms.TextBox();
            this.textBoxLage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAnzahlWE = new System.Windows.Forms.TextBox();
            this.buttonCreateWohnhus = new System.Windows.Forms.Button();
            this.groupBoxMieter = new System.Windows.Forms.GroupBox();
            this.buttonAddWohneinheit = new System.Windows.Forms.Button();
            this.groupBoxWohneinheit.SuspendLayout();
            this.groupBoxMieter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "neuer Mieter";
            // 
            // textBoxNeuerMieter
            // 
            this.textBoxNeuerMieter.Location = new System.Drawing.Point(117, 34);
            this.textBoxNeuerMieter.Name = "textBoxNeuerMieter";
            this.textBoxNeuerMieter.Size = new System.Drawing.Size(151, 20);
            this.textBoxNeuerMieter.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(284, 34);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(114, 21);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "hinzufügen";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anzahl der Mieter";
            // 
            // textBoxAnzahl
            // 
            this.textBoxAnzahl.Location = new System.Drawing.Point(117, 75);
            this.textBoxAnzahl.Name = "textBoxAnzahl";
            this.textBoxAnzahl.ReadOnly = true;
            this.textBoxAnzahl.Size = new System.Drawing.Size(150, 20);
            this.textBoxAnzahl.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Auszug";
            // 
            // textBoxAuszug
            // 
            this.textBoxAuszug.Location = new System.Drawing.Point(117, 131);
            this.textBoxAuszug.Name = "textBoxAuszug";
            this.textBoxAuszug.Size = new System.Drawing.Size(147, 20);
            this.textBoxAuszug.TabIndex = 6;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(287, 127);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(110, 24);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "entfernen";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // groupBoxWohneinheit
            // 
            this.groupBoxWohneinheit.Controls.Add(this.buttonAddWohneinheit);
            this.groupBoxWohneinheit.Controls.Add(this.textBoxLage);
            this.groupBoxWohneinheit.Controls.Add(this.textBoxGroesse);
            this.groupBoxWohneinheit.Controls.Add(this.textBoxPreis);
            this.groupBoxWohneinheit.Controls.Add(this.label6);
            this.groupBoxWohneinheit.Controls.Add(this.label5);
            this.groupBoxWohneinheit.Controls.Add(this.label4);
            this.groupBoxWohneinheit.Enabled = false;
            this.groupBoxWohneinheit.Location = new System.Drawing.Point(23, 64);
            this.groupBoxWohneinheit.Name = "groupBoxWohneinheit";
            this.groupBoxWohneinheit.Size = new System.Drawing.Size(462, 165);
            this.groupBoxWohneinheit.TabIndex = 8;
            this.groupBoxWohneinheit.TabStop = false;
            this.groupBoxWohneinheit.Text = "Wohneinheit aufnehmen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Preis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Göße";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lage";
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Location = new System.Drawing.Point(99, 16);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(107, 20);
            this.textBoxPreis.TabIndex = 3;
            // 
            // textBoxGroesse
            // 
            this.textBoxGroesse.Location = new System.Drawing.Point(97, 49);
            this.textBoxGroesse.Name = "textBoxGroesse";
            this.textBoxGroesse.Size = new System.Drawing.Size(109, 20);
            this.textBoxGroesse.TabIndex = 4;
            // 
            // textBoxLage
            // 
            this.textBoxLage.Location = new System.Drawing.Point(97, 84);
            this.textBoxLage.Name = "textBoxLage";
            this.textBoxLage.Size = new System.Drawing.Size(299, 20);
            this.textBoxLage.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Anzahl der Wohneinheiten";
            // 
            // textBoxAnzahlWE
            // 
            this.textBoxAnzahlWE.Location = new System.Drawing.Point(173, 14);
            this.textBoxAnzahlWE.Name = "textBoxAnzahlWE";
            this.textBoxAnzahlWE.Size = new System.Drawing.Size(56, 20);
            this.textBoxAnzahlWE.TabIndex = 10;
            // 
            // buttonCreateWohnhus
            // 
            this.buttonCreateWohnhus.Location = new System.Drawing.Point(253, 9);
            this.buttonCreateWohnhus.Name = "buttonCreateWohnhus";
            this.buttonCreateWohnhus.Size = new System.Drawing.Size(133, 24);
            this.buttonCreateWohnhus.TabIndex = 11;
            this.buttonCreateWohnhus.Text = "Wohnhaus erzeugen";
            this.buttonCreateWohnhus.UseVisualStyleBackColor = true;
            this.buttonCreateWohnhus.Click += new System.EventHandler(this.buttonCreateWohnhus_Click);
            // 
            // groupBoxMieter
            // 
            this.groupBoxMieter.Controls.Add(this.buttonRemove);
            this.groupBoxMieter.Controls.Add(this.textBoxAuszug);
            this.groupBoxMieter.Controls.Add(this.label3);
            this.groupBoxMieter.Controls.Add(this.textBoxAnzahl);
            this.groupBoxMieter.Controls.Add(this.label2);
            this.groupBoxMieter.Controls.Add(this.buttonAdd);
            this.groupBoxMieter.Controls.Add(this.textBoxNeuerMieter);
            this.groupBoxMieter.Controls.Add(this.label1);
            this.groupBoxMieter.Enabled = false;
            this.groupBoxMieter.Location = new System.Drawing.Point(22, 263);
            this.groupBoxMieter.Name = "groupBoxMieter";
            this.groupBoxMieter.Size = new System.Drawing.Size(462, 177);
            this.groupBoxMieter.TabIndex = 12;
            this.groupBoxMieter.TabStop = false;
            this.groupBoxMieter.Text = "Mieterverwaltung";
            // 
            // buttonAddWohneinheit
            // 
            this.buttonAddWohneinheit.Location = new System.Drawing.Point(21, 117);
            this.buttonAddWohneinheit.Name = "buttonAddWohneinheit";
            this.buttonAddWohneinheit.Size = new System.Drawing.Size(375, 33);
            this.buttonAddWohneinheit.TabIndex = 6;
            this.buttonAddWohneinheit.Text = "Wohneinheit hinzufügen";
            this.buttonAddWohneinheit.UseVisualStyleBackColor = true;
            this.buttonAddWohneinheit.Click += new System.EventHandler(this.buttonAddWohneinheit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 462);
            this.Controls.Add(this.groupBoxMieter);
            this.Controls.Add(this.buttonCreateWohnhus);
            this.Controls.Add(this.textBoxAnzahlWE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBoxWohneinheit);
            this.Name = "Form1";
            this.Text = "Wohnhaus verwalten";
            this.groupBoxWohneinheit.ResumeLayout(false);
            this.groupBoxWohneinheit.PerformLayout();
            this.groupBoxMieter.ResumeLayout(false);
            this.groupBoxMieter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNeuerMieter;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAnzahl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAuszug;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.GroupBox groupBoxWohneinheit;
        private System.Windows.Forms.TextBox textBoxLage;
        private System.Windows.Forms.TextBox textBoxGroesse;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAnzahlWE;
        private System.Windows.Forms.Button buttonCreateWohnhus;
        private System.Windows.Forms.Button buttonAddWohneinheit;
        private System.Windows.Forms.GroupBox groupBoxMieter;
    }
}

