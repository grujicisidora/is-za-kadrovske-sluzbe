
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class UCOdeljenja
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
            this.osveziBtn = new System.Windows.Forms.Button();
            this.nazadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.pretraziBtn = new System.Windows.Forms.Button();
            this.nazivOdeljenjaTxt = new System.Windows.Forms.TextBox();
            this.pretraziTxt = new System.Windows.Forms.TextBox();
            this.odeljenjaLv = new System.Windows.Forms.ListView();
            this.obrisiTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // osveziBtn
            // 
            this.osveziBtn.Location = new System.Drawing.Point(146, 10);
            this.osveziBtn.Name = "osveziBtn";
            this.osveziBtn.Size = new System.Drawing.Size(147, 49);
            this.osveziBtn.TabIndex = 37;
            this.osveziBtn.Text = "Osveži pregled";
            this.osveziBtn.UseVisualStyleBackColor = true;
            this.osveziBtn.Click += new System.EventHandler(this.osveziBtn_Click);
            // 
            // nazadBtn
            // 
            this.nazadBtn.Location = new System.Drawing.Point(548, 437);
            this.nazadBtn.Name = "nazadBtn";
            this.nazadBtn.Size = new System.Drawing.Size(147, 49);
            this.nazadBtn.TabIndex = 36;
            this.nazadBtn.Text = "Nazad";
            this.nazadBtn.UseVisualStyleBackColor = true;
            this.nazadBtn.Click += new System.EventHandler(this.nazadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Naziv odeljenja:";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(548, 242);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(147, 49);
            this.dodajBtn.TabIndex = 33;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.Location = new System.Drawing.Point(252, 437);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(147, 49);
            this.obrisiBtn.TabIndex = 32;
            this.obrisiBtn.Text = "Obriši";
            this.obrisiBtn.UseVisualStyleBackColor = true;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // pretraziBtn
            // 
            this.pretraziBtn.Location = new System.Drawing.Point(41, 437);
            this.pretraziBtn.Name = "pretraziBtn";
            this.pretraziBtn.Size = new System.Drawing.Size(147, 49);
            this.pretraziBtn.TabIndex = 31;
            this.pretraziBtn.Text = "Pretraži";
            this.pretraziBtn.UseVisualStyleBackColor = true;
            this.pretraziBtn.Click += new System.EventHandler(this.pretraziBtn_Click);
            // 
            // nazivOdeljenjaTxt
            // 
            this.nazivOdeljenjaTxt.Location = new System.Drawing.Point(616, 183);
            this.nazivOdeljenjaTxt.Name = "nazivOdeljenjaTxt";
            this.nazivOdeljenjaTxt.Size = new System.Drawing.Size(171, 27);
            this.nazivOdeljenjaTxt.TabIndex = 30;
            // 
            // pretraziTxt
            // 
            this.pretraziTxt.Location = new System.Drawing.Point(30, 395);
            this.pretraziTxt.Name = "pretraziTxt";
            this.pretraziTxt.Size = new System.Drawing.Size(171, 27);
            this.pretraziTxt.TabIndex = 29;
            // 
            // odeljenjaLv
            // 
            this.odeljenjaLv.HideSelection = false;
            this.odeljenjaLv.Location = new System.Drawing.Point(30, 65);
            this.odeljenjaLv.Name = "odeljenjaLv";
            this.odeljenjaLv.Size = new System.Drawing.Size(381, 278);
            this.odeljenjaLv.TabIndex = 28;
            this.odeljenjaLv.UseCompatibleStateImageBehavior = false;
            this.odeljenjaLv.View = System.Windows.Forms.View.List;
            // 
            // obrisiTxt
            // 
            this.obrisiTxt.Location = new System.Drawing.Point(240, 395);
            this.obrisiTxt.Name = "obrisiTxt";
            this.obrisiTxt.Size = new System.Drawing.Size(171, 27);
            this.obrisiTxt.TabIndex = 38;
            // 
            // UCOdeljenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.obrisiTxt);
            this.Controls.Add(this.osveziBtn);
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.pretraziBtn);
            this.Controls.Add(this.nazivOdeljenjaTxt);
            this.Controls.Add(this.pretraziTxt);
            this.Controls.Add(this.odeljenjaLv);
            this.Name = "UCOdeljenja";
            this.Size = new System.Drawing.Size(818, 497);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button osveziBtn;
        private System.Windows.Forms.Button nazadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button obrisiBtn;
        private System.Windows.Forms.Button pretraziBtn;
        private System.Windows.Forms.TextBox nazivOdeljenjaTxt;
        private System.Windows.Forms.TextBox pretraziTxt;
        private System.Windows.Forms.ListView odeljenjaLv;
        private System.Windows.Forms.TextBox obrisiTxt;
    }
}
