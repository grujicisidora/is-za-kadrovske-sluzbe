
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class UCGradovi
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
            this.gradoviLv = new System.Windows.Forms.ListView();
            this.pretraziTxt = new System.Windows.Forms.TextBox();
            this.obrisiTxt = new System.Windows.Forms.TextBox();
            this.pttTxt = new System.Windows.Forms.TextBox();
            this.gradTxt = new System.Windows.Forms.TextBox();
            this.pretraziBtn = new System.Windows.Forms.Button();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazadBtn = new System.Windows.Forms.Button();
            this.osveziBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gradoviLv
            // 
            this.gradoviLv.HideSelection = false;
            this.gradoviLv.Location = new System.Drawing.Point(59, 63);
            this.gradoviLv.Name = "gradoviLv";
            this.gradoviLv.Size = new System.Drawing.Size(381, 278);
            this.gradoviLv.TabIndex = 0;
            this.gradoviLv.UseCompatibleStateImageBehavior = false;
            this.gradoviLv.View = System.Windows.Forms.View.List;
            // 
            // pretraziTxt
            // 
            this.pretraziTxt.Location = new System.Drawing.Point(59, 393);
            this.pretraziTxt.Name = "pretraziTxt";
            this.pretraziTxt.Size = new System.Drawing.Size(171, 27);
            this.pretraziTxt.TabIndex = 1;
            // 
            // obrisiTxt
            // 
            this.obrisiTxt.Location = new System.Drawing.Point(269, 393);
            this.obrisiTxt.Name = "obrisiTxt";
            this.obrisiTxt.Size = new System.Drawing.Size(171, 27);
            this.obrisiTxt.TabIndex = 2;
            // 
            // pttTxt
            // 
            this.pttTxt.Location = new System.Drawing.Point(564, 137);
            this.pttTxt.Name = "pttTxt";
            this.pttTxt.Size = new System.Drawing.Size(171, 27);
            this.pttTxt.TabIndex = 3;
            // 
            // gradTxt
            // 
            this.gradTxt.Location = new System.Drawing.Point(564, 196);
            this.gradTxt.Name = "gradTxt";
            this.gradTxt.Size = new System.Drawing.Size(171, 27);
            this.gradTxt.TabIndex = 4;
            // 
            // pretraziBtn
            // 
            this.pretraziBtn.Location = new System.Drawing.Point(70, 435);
            this.pretraziBtn.Name = "pretraziBtn";
            this.pretraziBtn.Size = new System.Drawing.Size(147, 49);
            this.pretraziBtn.TabIndex = 5;
            this.pretraziBtn.Text = "Pretraži";
            this.pretraziBtn.UseVisualStyleBackColor = true;
            this.pretraziBtn.Click += new System.EventHandler(this.pretraziBtn_Click);
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.Location = new System.Drawing.Point(281, 435);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(147, 49);
            this.obrisiBtn.TabIndex = 6;
            this.obrisiBtn.Text = "Obriši";
            this.obrisiBtn.UseVisualStyleBackColor = true;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(577, 256);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(147, 49);
            this.dodajBtn.TabIndex = 7;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Poštanski broj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Naziv grada:";
            // 
            // nazadBtn
            // 
            this.nazadBtn.Location = new System.Drawing.Point(577, 435);
            this.nazadBtn.Name = "nazadBtn";
            this.nazadBtn.Size = new System.Drawing.Size(147, 49);
            this.nazadBtn.TabIndex = 10;
            this.nazadBtn.Text = "Nazad";
            this.nazadBtn.UseVisualStyleBackColor = true;
            this.nazadBtn.Click += new System.EventHandler(this.nazadBtn_Click);
            // 
            // osveziBtn
            // 
            this.osveziBtn.Location = new System.Drawing.Point(175, 8);
            this.osveziBtn.Name = "osveziBtn";
            this.osveziBtn.Size = new System.Drawing.Size(147, 49);
            this.osveziBtn.TabIndex = 11;
            this.osveziBtn.Text = "Osveži pregled";
            this.osveziBtn.UseVisualStyleBackColor = true;
            this.osveziBtn.Click += new System.EventHandler(this.osveziBtn_Click);
            // 
            // UCGradovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.osveziBtn);
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.pretraziBtn);
            this.Controls.Add(this.gradTxt);
            this.Controls.Add(this.pttTxt);
            this.Controls.Add(this.obrisiTxt);
            this.Controls.Add(this.pretraziTxt);
            this.Controls.Add(this.gradoviLv);
            this.Name = "UCGradovi";
            this.Size = new System.Drawing.Size(852, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView gradoviLv;
        private System.Windows.Forms.TextBox pretraziTxt;
        private System.Windows.Forms.TextBox obrisiTxt;
        private System.Windows.Forms.TextBox pttTxt;
        private System.Windows.Forms.TextBox gradTxt;
        private System.Windows.Forms.Button pretraziBtn;
        private System.Windows.Forms.Button obrisiBtn;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nazadBtn;
        private System.Windows.Forms.Button osveziBtn;
    }
}
