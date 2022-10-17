
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class UCObrazovneUstanove
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
            this.nazivObrUstTxt = new System.Windows.Forms.TextBox();
            this.pretraziTxt = new System.Windows.Forms.TextBox();
            this.obrUstLv = new System.Windows.Forms.ListView();
            this.stepenObrComboBox = new System.Windows.Forms.ComboBox();
            this.gradComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.obrisiComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // osveziBtn
            // 
            this.osveziBtn.Location = new System.Drawing.Point(176, 20);
            this.osveziBtn.Name = "osveziBtn";
            this.osveziBtn.Size = new System.Drawing.Size(147, 49);
            this.osveziBtn.TabIndex = 23;
            this.osveziBtn.Text = "Osveži pregled";
            this.osveziBtn.UseVisualStyleBackColor = true;
            this.osveziBtn.Click += new System.EventHandler(this.osveziBtn_Click);
            // 
            // nazadBtn
            // 
            this.nazadBtn.Location = new System.Drawing.Point(578, 447);
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
            this.label2.Location = new System.Drawing.Point(498, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Stepen obrazovanja:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Naziv obrazovne ustanove:";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(578, 318);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(147, 49);
            this.dodajBtn.TabIndex = 19;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.Location = new System.Drawing.Point(282, 447);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(147, 49);
            this.obrisiBtn.TabIndex = 18;
            this.obrisiBtn.Text = "Obriši";
            this.obrisiBtn.UseVisualStyleBackColor = true;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // pretraziBtn
            // 
            this.pretraziBtn.Location = new System.Drawing.Point(71, 447);
            this.pretraziBtn.Name = "pretraziBtn";
            this.pretraziBtn.Size = new System.Drawing.Size(147, 49);
            this.pretraziBtn.TabIndex = 17;
            this.pretraziBtn.Text = "Filtriraj po gradu";
            this.pretraziBtn.UseVisualStyleBackColor = true;
            this.pretraziBtn.Click += new System.EventHandler(this.pretraziBtn_Click);
            // 
            // nazivObrUstTxt
            // 
            this.nazivObrUstTxt.Location = new System.Drawing.Point(648, 149);
            this.nazivObrUstTxt.Name = "nazivObrUstTxt";
            this.nazivObrUstTxt.Size = new System.Drawing.Size(171, 27);
            this.nazivObrUstTxt.TabIndex = 15;
            // 
            // pretraziTxt
            // 
            this.pretraziTxt.Location = new System.Drawing.Point(60, 405);
            this.pretraziTxt.Name = "pretraziTxt";
            this.pretraziTxt.Size = new System.Drawing.Size(171, 27);
            this.pretraziTxt.TabIndex = 13;
            // 
            // obrUstLv
            // 
            this.obrUstLv.HideSelection = false;
            this.obrUstLv.Location = new System.Drawing.Point(60, 75);
            this.obrUstLv.Name = "obrUstLv";
            this.obrUstLv.Size = new System.Drawing.Size(381, 278);
            this.obrUstLv.TabIndex = 12;
            this.obrUstLv.UseCompatibleStateImageBehavior = false;
            this.obrUstLv.View = System.Windows.Forms.View.List;
            // 
            // stepenObrComboBox
            // 
            this.stepenObrComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.stepenObrComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.stepenObrComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stepenObrComboBox.FormattingEnabled = true;
            this.stepenObrComboBox.Items.AddRange(new object[] {
            "Osnovna škola",
            "Strukovna škola",
            "Srednja škola ",
            "Viša škola",
            "Fakultet"});
            this.stepenObrComboBox.Location = new System.Drawing.Point(648, 201);
            this.stepenObrComboBox.Name = "stepenObrComboBox";
            this.stepenObrComboBox.Size = new System.Drawing.Size(170, 28);
            this.stepenObrComboBox.TabIndex = 24;
            // 
            // gradComboBox
            // 
            this.gradComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.gradComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gradComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradComboBox.FormattingEnabled = true;
            this.gradComboBox.Location = new System.Drawing.Point(648, 257);
            this.gradComboBox.Name = "gradComboBox";
            this.gradComboBox.Size = new System.Drawing.Size(170, 28);
            this.gradComboBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Grad:";
            // 
            // obrisiComboBox
            // 
            this.obrisiComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.obrisiComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.obrisiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obrisiComboBox.FormattingEnabled = true;
            this.obrisiComboBox.Location = new System.Drawing.Point(271, 405);
            this.obrisiComboBox.Name = "obrisiComboBox";
            this.obrisiComboBox.Size = new System.Drawing.Size(170, 28);
            this.obrisiComboBox.TabIndex = 27;
            // 
            // UCObrazovneUstanove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.obrisiComboBox);
            this.Controls.Add(this.gradComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stepenObrComboBox);
            this.Controls.Add(this.osveziBtn);
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.pretraziBtn);
            this.Controls.Add(this.nazivObrUstTxt);
            this.Controls.Add(this.pretraziTxt);
            this.Controls.Add(this.obrUstLv);
            this.Name = "UCObrazovneUstanove";
            this.Size = new System.Drawing.Size(852, 528);
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
        private System.Windows.Forms.TextBox nazivObrUstTxt;
        private System.Windows.Forms.TextBox pretraziTxt;
        private System.Windows.Forms.ListView obrUstLv;
        private System.Windows.Forms.ComboBox stepenObrComboBox;
        private System.Windows.Forms.ComboBox gradComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox obrisiComboBox;
    }
}
