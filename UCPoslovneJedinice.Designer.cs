
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class UCPoslovneJedinice
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
            this.obrisiComboBox = new System.Windows.Forms.ComboBox();
            this.gradComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.osveziBtn = new System.Windows.Forms.Button();
            this.nazadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.pretraziBtn = new System.Windows.Forms.Button();
            this.adresaTxt = new System.Windows.Forms.TextBox();
            this.pretraziTxt = new System.Windows.Forms.TextBox();
            this.poslJedLv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // obrisiComboBox
            // 
            this.obrisiComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.obrisiComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.obrisiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obrisiComboBox.FormattingEnabled = true;
            this.obrisiComboBox.Location = new System.Drawing.Point(250, 397);
            this.obrisiComboBox.Name = "obrisiComboBox";
            this.obrisiComboBox.Size = new System.Drawing.Size(170, 28);
            this.obrisiComboBox.TabIndex = 41;
            // 
            // gradComboBox
            // 
            this.gradComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.gradComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gradComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradComboBox.FormattingEnabled = true;
            this.gradComboBox.Location = new System.Drawing.Point(591, 197);
            this.gradComboBox.Name = "gradComboBox";
            this.gradComboBox.Size = new System.Drawing.Size(170, 28);
            this.gradComboBox.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Grad:";
            // 
            // osveziBtn
            // 
            this.osveziBtn.Location = new System.Drawing.Point(155, 12);
            this.osveziBtn.Name = "osveziBtn";
            this.osveziBtn.Size = new System.Drawing.Size(147, 49);
            this.osveziBtn.TabIndex = 37;
            this.osveziBtn.Text = "Osveži pregled";
            this.osveziBtn.UseVisualStyleBackColor = true;
            this.osveziBtn.Click += new System.EventHandler(this.osveziBtn_Click);
            // 
            // nazadBtn
            // 
            this.nazadBtn.Location = new System.Drawing.Point(557, 439);
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
            this.label1.Location = new System.Drawing.Point(487, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Adresa:";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(557, 275);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(147, 49);
            this.dodajBtn.TabIndex = 33;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.Location = new System.Drawing.Point(261, 439);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(147, 49);
            this.obrisiBtn.TabIndex = 32;
            this.obrisiBtn.Text = "Obriši";
            this.obrisiBtn.UseVisualStyleBackColor = true;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // pretraziBtn
            // 
            this.pretraziBtn.Location = new System.Drawing.Point(50, 439);
            this.pretraziBtn.Name = "pretraziBtn";
            this.pretraziBtn.Size = new System.Drawing.Size(147, 49);
            this.pretraziBtn.TabIndex = 31;
            this.pretraziBtn.Text = "Filtriraj po gradu";
            this.pretraziBtn.UseVisualStyleBackColor = true;
            this.pretraziBtn.Click += new System.EventHandler(this.pretraziBtn_Click);
            // 
            // adresaTxt
            // 
            this.adresaTxt.Location = new System.Drawing.Point(591, 141);
            this.adresaTxt.Name = "adresaTxt";
            this.adresaTxt.Size = new System.Drawing.Size(171, 27);
            this.adresaTxt.TabIndex = 30;
            // 
            // pretraziTxt
            // 
            this.pretraziTxt.Location = new System.Drawing.Point(39, 397);
            this.pretraziTxt.Name = "pretraziTxt";
            this.pretraziTxt.Size = new System.Drawing.Size(171, 27);
            this.pretraziTxt.TabIndex = 29;
            // 
            // poslJedLv
            // 
            this.poslJedLv.HideSelection = false;
            this.poslJedLv.Location = new System.Drawing.Point(39, 67);
            this.poslJedLv.Name = "poslJedLv";
            this.poslJedLv.Size = new System.Drawing.Size(381, 278);
            this.poslJedLv.TabIndex = 28;
            this.poslJedLv.UseCompatibleStateImageBehavior = false;
            this.poslJedLv.View = System.Windows.Forms.View.List;
            // 
            // UCPoslovneJedinice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.obrisiComboBox);
            this.Controls.Add(this.gradComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.osveziBtn);
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.pretraziBtn);
            this.Controls.Add(this.adresaTxt);
            this.Controls.Add(this.pretraziTxt);
            this.Controls.Add(this.poslJedLv);
            this.Name = "UCPoslovneJedinice";
            this.Size = new System.Drawing.Size(818, 497);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox obrisiComboBox;
        private System.Windows.Forms.ComboBox gradComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button osveziBtn;
        private System.Windows.Forms.Button nazadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button obrisiBtn;
        private System.Windows.Forms.Button pretraziBtn;
        private System.Windows.Forms.TextBox adresaTxt;
        private System.Windows.Forms.TextBox pretraziTxt;
        private System.Windows.Forms.ListView poslJedLv;
    }
}
