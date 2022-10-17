
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class UCBanke
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
            this.label2 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.pretraziBtn = new System.Windows.Forms.Button();
            this.nazivTxt = new System.Windows.Forms.TextBox();
            this.obrisiTxt = new System.Windows.Forms.TextBox();
            this.pretraziTxt = new System.Windows.Forms.TextBox();
            this.bankeLv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // osveziBtn
            // 
            this.osveziBtn.Location = new System.Drawing.Point(171, 9);
            this.osveziBtn.Name = "osveziBtn";
            this.osveziBtn.Size = new System.Drawing.Size(147, 49);
            this.osveziBtn.TabIndex = 23;
            this.osveziBtn.Text = "Osveži pregled";
            this.osveziBtn.UseVisualStyleBackColor = true;
            this.osveziBtn.Click += new System.EventHandler(this.osveziBtn_Click);
            // 
            // nazadBtn
            // 
            this.nazadBtn.Location = new System.Drawing.Point(573, 436);
            this.nazadBtn.Name = "nazadBtn";
            this.nazadBtn.Size = new System.Drawing.Size(147, 49);
            this.nazadBtn.TabIndex = 22;
            this.nazadBtn.Text = "Nazad";
            this.nazadBtn.UseVisualStyleBackColor = true;
            this.nazadBtn.Click += new System.EventHandler(this.nazadBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Naziv banke:";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(573, 257);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(147, 49);
            this.dodajBtn.TabIndex = 19;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.Location = new System.Drawing.Point(277, 436);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(147, 49);
            this.obrisiBtn.TabIndex = 18;
            this.obrisiBtn.Text = "Obriši";
            this.obrisiBtn.UseVisualStyleBackColor = true;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // pretraziBtn
            // 
            this.pretraziBtn.Location = new System.Drawing.Point(66, 436);
            this.pretraziBtn.Name = "pretraziBtn";
            this.pretraziBtn.Size = new System.Drawing.Size(147, 49);
            this.pretraziBtn.TabIndex = 17;
            this.pretraziBtn.Text = "Pretraži";
            this.pretraziBtn.UseVisualStyleBackColor = true;
            this.pretraziBtn.Click += new System.EventHandler(this.pretraziBtn_Click);
            // 
            // nazivTxt
            // 
            this.nazivTxt.Location = new System.Drawing.Point(560, 197);
            this.nazivTxt.Name = "nazivTxt";
            this.nazivTxt.Size = new System.Drawing.Size(171, 27);
            this.nazivTxt.TabIndex = 16;
            // 
            // obrisiTxt
            // 
            this.obrisiTxt.Location = new System.Drawing.Point(265, 394);
            this.obrisiTxt.Name = "obrisiTxt";
            this.obrisiTxt.Size = new System.Drawing.Size(171, 27);
            this.obrisiTxt.TabIndex = 14;
            // 
            // pretraziTxt
            // 
            this.pretraziTxt.Location = new System.Drawing.Point(55, 394);
            this.pretraziTxt.Name = "pretraziTxt";
            this.pretraziTxt.Size = new System.Drawing.Size(171, 27);
            this.pretraziTxt.TabIndex = 13;
            // 
            // bankeLv
            // 
            this.bankeLv.HideSelection = false;
            this.bankeLv.Location = new System.Drawing.Point(55, 64);
            this.bankeLv.Name = "bankeLv";
            this.bankeLv.Size = new System.Drawing.Size(381, 278);
            this.bankeLv.TabIndex = 12;
            this.bankeLv.UseCompatibleStateImageBehavior = false;
            this.bankeLv.View = System.Windows.Forms.View.List;
            // 
            // UCBanke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.osveziBtn);
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.pretraziBtn);
            this.Controls.Add(this.nazivTxt);
            this.Controls.Add(this.obrisiTxt);
            this.Controls.Add(this.pretraziTxt);
            this.Controls.Add(this.bankeLv);
            this.Name = "UCBanke";
            this.Size = new System.Drawing.Size(818, 516);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button osveziBtn;
        private System.Windows.Forms.Button nazadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button obrisiBtn;
        private System.Windows.Forms.Button pretraziBtn;
        private System.Windows.Forms.TextBox nazivTxt;
        private System.Windows.Forms.TextBox obrisiTxt;
        private System.Windows.Forms.TextBox pretraziTxt;
        private System.Windows.Forms.ListView bankeLv;
    }
}
