
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class UCRadnaMesta
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
            this.label1 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.pretraziBtn = new System.Windows.Forms.Button();
            this.nazivRadMestaTxt = new System.Windows.Forms.TextBox();
            this.obrisiTxt = new System.Windows.Forms.TextBox();
            this.pretraziTxt = new System.Windows.Forms.TextBox();
            this.radMestaLv = new System.Windows.Forms.ListView();
            this.opisTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // osveziBtn
            // 
            this.osveziBtn.Location = new System.Drawing.Point(171, 4);
            this.osveziBtn.Name = "osveziBtn";
            this.osveziBtn.Size = new System.Drawing.Size(147, 49);
            this.osveziBtn.TabIndex = 23;
            this.osveziBtn.Text = "Osveži pregled";
            this.osveziBtn.UseVisualStyleBackColor = true;
            this.osveziBtn.Click += new System.EventHandler(this.osveziBtn_Click);
            // 
            // nazadBtn
            // 
            this.nazadBtn.Location = new System.Drawing.Point(569, 431);
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
            this.label2.Location = new System.Drawing.Point(451, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Opis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Naziv radnog mesta:";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(569, 343);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(147, 49);
            this.dodajBtn.TabIndex = 19;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.Location = new System.Drawing.Point(277, 431);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(147, 49);
            this.obrisiBtn.TabIndex = 18;
            this.obrisiBtn.Text = "Obriši";
            this.obrisiBtn.UseVisualStyleBackColor = true;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // pretraziBtn
            // 
            this.pretraziBtn.Location = new System.Drawing.Point(66, 431);
            this.pretraziBtn.Name = "pretraziBtn";
            this.pretraziBtn.Size = new System.Drawing.Size(147, 49);
            this.pretraziBtn.TabIndex = 17;
            this.pretraziBtn.Text = "Pretraži";
            this.pretraziBtn.UseVisualStyleBackColor = true;
            this.pretraziBtn.Click += new System.EventHandler(this.pretraziBtn_Click);
            // 
            // nazivRadMestaTxt
            // 
            this.nazivRadMestaTxt.Location = new System.Drawing.Point(602, 133);
            this.nazivRadMestaTxt.Name = "nazivRadMestaTxt";
            this.nazivRadMestaTxt.Size = new System.Drawing.Size(171, 27);
            this.nazivRadMestaTxt.TabIndex = 15;
            // 
            // obrisiTxt
            // 
            this.obrisiTxt.Location = new System.Drawing.Point(265, 389);
            this.obrisiTxt.Name = "obrisiTxt";
            this.obrisiTxt.Size = new System.Drawing.Size(171, 27);
            this.obrisiTxt.TabIndex = 14;
            // 
            // pretraziTxt
            // 
            this.pretraziTxt.Location = new System.Drawing.Point(55, 389);
            this.pretraziTxt.Name = "pretraziTxt";
            this.pretraziTxt.Size = new System.Drawing.Size(171, 27);
            this.pretraziTxt.TabIndex = 13;
            // 
            // radMestaLv
            // 
            this.radMestaLv.HideSelection = false;
            this.radMestaLv.Location = new System.Drawing.Point(55, 59);
            this.radMestaLv.Name = "radMestaLv";
            this.radMestaLv.Size = new System.Drawing.Size(381, 278);
            this.radMestaLv.TabIndex = 12;
            this.radMestaLv.UseCompatibleStateImageBehavior = false;
            this.radMestaLv.View = System.Windows.Forms.View.List;
            this.radMestaLv.SelectedIndexChanged += new System.EventHandler(this.radMestaLv_SelectedIndexChanged);
            // 
            // opisTxt
            // 
            this.opisTxt.Location = new System.Drawing.Point(499, 192);
            this.opisTxt.Name = "opisTxt";
            this.opisTxt.Size = new System.Drawing.Size(274, 129);
            this.opisTxt.TabIndex = 24;
            this.opisTxt.Text = "";
            // 
            // UCRadnaMesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.opisTxt);
            this.Controls.Add(this.osveziBtn);
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.pretraziBtn);
            this.Controls.Add(this.nazivRadMestaTxt);
            this.Controls.Add(this.obrisiTxt);
            this.Controls.Add(this.pretraziTxt);
            this.Controls.Add(this.radMestaLv);
            this.Name = "UCRadnaMesta";
            this.Size = new System.Drawing.Size(818, 497);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button osveziBtn;
        private System.Windows.Forms.Button nazadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button obrisiBtn;
        private System.Windows.Forms.Button pretraziBtn;
        private System.Windows.Forms.TextBox nazivRadMestaTxt;
        private System.Windows.Forms.TextBox obrisiTxt;
        private System.Windows.Forms.TextBox pretraziTxt;
        private System.Windows.Forms.ListView radMestaLv;
        private System.Windows.Forms.RichTextBox opisTxt;
    }
}
