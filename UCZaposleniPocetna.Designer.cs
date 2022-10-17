
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class UCZaposleniPocetna
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dodajZaposlenogBtn = new System.Windows.Forms.Button();
            this.spisakZaposlenihBtn = new System.Windows.Forms.Button();
            this.nazadNaPocetnuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodajZaposlenogBtn
            // 
            this.dodajZaposlenogBtn.Location = new System.Drawing.Point(125, 203);
            this.dodajZaposlenogBtn.Name = "dodajZaposlenogBtn";
            this.dodajZaposlenogBtn.Size = new System.Drawing.Size(241, 63);
            this.dodajZaposlenogBtn.TabIndex = 0;
            this.dodajZaposlenogBtn.Text = "Dodaj novog zaposlenog";
            this.dodajZaposlenogBtn.UseVisualStyleBackColor = true;
            this.dodajZaposlenogBtn.Click += new System.EventHandler(this.dodajZaposlenogBtn_Click);
            // 
            // spisakZaposlenihBtn
            // 
            this.spisakZaposlenihBtn.Location = new System.Drawing.Point(425, 203);
            this.spisakZaposlenihBtn.Name = "spisakZaposlenihBtn";
            this.spisakZaposlenihBtn.Size = new System.Drawing.Size(241, 63);
            this.spisakZaposlenihBtn.TabIndex = 1;
            this.spisakZaposlenihBtn.Text = "Spisak zaposlenih";
            this.spisakZaposlenihBtn.UseVisualStyleBackColor = true;
            this.spisakZaposlenihBtn.Click += new System.EventHandler(this.spisakZaposlenihBtn_Click);
            // 
            // nazadNaPocetnuBtn
            // 
            this.nazadNaPocetnuBtn.Location = new System.Drawing.Point(278, 369);
            this.nazadNaPocetnuBtn.Name = "nazadNaPocetnuBtn";
            this.nazadNaPocetnuBtn.Size = new System.Drawing.Size(241, 63);
            this.nazadNaPocetnuBtn.TabIndex = 2;
            this.nazadNaPocetnuBtn.Text = "Nazad na počentu";
            this.nazadNaPocetnuBtn.UseVisualStyleBackColor = true;
            this.nazadNaPocetnuBtn.Click += new System.EventHandler(this.nazadNaPocetnuBtn_Click);
            // 
            // UCZaposleniPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nazadNaPocetnuBtn);
            this.Controls.Add(this.spisakZaposlenihBtn);
            this.Controls.Add(this.dodajZaposlenogBtn);
            this.Name = "UCZaposleniPocetna";
            this.Size = new System.Drawing.Size(818, 497);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodajZaposlenogBtn;
        private System.Windows.Forms.Button spisakZaposlenihBtn;
        private System.Windows.Forms.Button nazadNaPocetnuBtn;
    }
}
