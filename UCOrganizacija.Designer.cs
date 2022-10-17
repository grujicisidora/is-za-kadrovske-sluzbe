
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class UCOrganizacija
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
            this.pretraziComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.odeljenjeComboBox = new System.Windows.Forms.ComboBox();
            this.osveziBtn = new System.Windows.Forms.Button();
            this.nazadBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.pretraziBtn = new System.Windows.Forms.Button();
            this.obrisiTxt = new System.Windows.Forms.TextBox();
            this.organizacijaLv = new System.Windows.Forms.ListView();
            this.poslJedComboBox = new System.Windows.Forms.ComboBox();
            this.radMestoComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // pretraziComboBox
            // 
            this.pretraziComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pretraziComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pretraziComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pretraziComboBox.FormattingEnabled = true;
            this.pretraziComboBox.Location = new System.Drawing.Point(33, 405);
            this.pretraziComboBox.Name = "pretraziComboBox";
            this.pretraziComboBox.Size = new System.Drawing.Size(170, 28);
            this.pretraziComboBox.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Radno mesto:";
            // 
            // odeljenjeComboBox
            // 
            this.odeljenjeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.odeljenjeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.odeljenjeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odeljenjeComboBox.FormattingEnabled = true;
            this.odeljenjeComboBox.Location = new System.Drawing.Point(595, 202);
            this.odeljenjeComboBox.Name = "odeljenjeComboBox";
            this.odeljenjeComboBox.Size = new System.Drawing.Size(194, 28);
            this.odeljenjeComboBox.TabIndex = 53;
            // 
            // osveziBtn
            // 
            this.osveziBtn.Location = new System.Drawing.Point(149, 21);
            this.osveziBtn.Name = "osveziBtn";
            this.osveziBtn.Size = new System.Drawing.Size(147, 49);
            this.osveziBtn.TabIndex = 52;
            this.osveziBtn.Text = "Osveži pregled";
            this.osveziBtn.UseVisualStyleBackColor = true;
            this.osveziBtn.Click += new System.EventHandler(this.osveziBtn_Click);
            // 
            // nazadBtn
            // 
            this.nazadBtn.Location = new System.Drawing.Point(551, 448);
            this.nazadBtn.Name = "nazadBtn";
            this.nazadBtn.Size = new System.Drawing.Size(147, 49);
            this.nazadBtn.TabIndex = 51;
            this.nazadBtn.Text = "Nazad";
            this.nazadBtn.UseVisualStyleBackColor = true;
            this.nazadBtn.Click += new System.EventHandler(this.nazadBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Odeljenje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Poslovna jedinica:";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(551, 319);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(147, 49);
            this.dodajBtn.TabIndex = 48;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.Location = new System.Drawing.Point(255, 448);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(147, 49);
            this.obrisiBtn.TabIndex = 47;
            this.obrisiBtn.Text = "Obriši";
            this.obrisiBtn.UseVisualStyleBackColor = true;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // pretraziBtn
            // 
            this.pretraziBtn.Location = new System.Drawing.Point(33, 448);
            this.pretraziBtn.Name = "pretraziBtn";
            this.pretraziBtn.Size = new System.Drawing.Size(170, 49);
            this.pretraziBtn.TabIndex = 46;
            this.pretraziBtn.Text = "Pretraži po odeljenju";
            this.pretraziBtn.UseVisualStyleBackColor = true;
            this.pretraziBtn.Click += new System.EventHandler(this.pretraziBtn_Click);
            // 
            // obrisiTxt
            // 
            this.obrisiTxt.Location = new System.Drawing.Point(243, 405);
            this.obrisiTxt.Name = "obrisiTxt";
            this.obrisiTxt.Size = new System.Drawing.Size(171, 27);
            this.obrisiTxt.TabIndex = 44;
            // 
            // organizacijaLv
            // 
            this.organizacijaLv.HideSelection = false;
            this.organizacijaLv.Location = new System.Drawing.Point(33, 76);
            this.organizacijaLv.Name = "organizacijaLv";
            this.organizacijaLv.Size = new System.Drawing.Size(381, 278);
            this.organizacijaLv.TabIndex = 43;
            this.organizacijaLv.UseCompatibleStateImageBehavior = false;
            this.organizacijaLv.View = System.Windows.Forms.View.List;
            // 
            // poslJedComboBox
            // 
            this.poslJedComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.poslJedComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.poslJedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poslJedComboBox.FormattingEnabled = true;
            this.poslJedComboBox.Location = new System.Drawing.Point(595, 150);
            this.poslJedComboBox.Name = "poslJedComboBox";
            this.poslJedComboBox.Size = new System.Drawing.Size(194, 28);
            this.poslJedComboBox.TabIndex = 56;
            // 
            // radMestoComboBox
            // 
            this.radMestoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.radMestoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.radMestoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.radMestoComboBox.FormattingEnabled = true;
            this.radMestoComboBox.Location = new System.Drawing.Point(595, 258);
            this.radMestoComboBox.Name = "radMestoComboBox";
            this.radMestoComboBox.Size = new System.Drawing.Size(194, 28);
            this.radMestoComboBox.TabIndex = 57;
            // 
            // UCOrganizacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radMestoComboBox);
            this.Controls.Add(this.poslJedComboBox);
            this.Controls.Add(this.pretraziComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odeljenjeComboBox);
            this.Controls.Add(this.osveziBtn);
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.pretraziBtn);
            this.Controls.Add(this.obrisiTxt);
            this.Controls.Add(this.organizacijaLv);
            this.Name = "UCOrganizacija";
            this.Size = new System.Drawing.Size(839, 519);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox pretraziComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox odeljenjeComboBox;
        private System.Windows.Forms.Button osveziBtn;
        private System.Windows.Forms.Button nazadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button obrisiBtn;
        private System.Windows.Forms.Button pretraziBtn;
        private System.Windows.Forms.TextBox obrisiTxt;
        private System.Windows.Forms.ListView organizacijaLv;
        private System.Windows.Forms.ComboBox poslJedComboBox;
        private System.Windows.Forms.ComboBox radMestoComboBox;
    }
}
