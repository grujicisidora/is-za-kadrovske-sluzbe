
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class UCUgovori
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
            this.tipUgovoraComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.osveziBtn = new System.Windows.Forms.Button();
            this.nazadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.pretraziTipBtn = new System.Windows.Forms.Button();
            this.trajanjeTxt = new System.Windows.Forms.TextBox();
            this.ugovoriLv = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.plataTxt = new System.Windows.Forms.TextBox();
            this.datumDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.obrisiTxt = new System.Windows.Forms.TextBox();
            this.pretraziDTP = new System.Windows.Forms.DateTimePicker();
            this.pretraziTipComboBox = new System.Windows.Forms.ComboBox();
            this.pretraziDatumBtn = new System.Windows.Forms.Button();
            this.pretraziBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pretraziIdTxt = new System.Windows.Forms.TextBox();
            this.pretraziIdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tipUgovoraComboBox
            // 
            this.tipUgovoraComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tipUgovoraComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tipUgovoraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipUgovoraComboBox.FormattingEnabled = true;
            this.tipUgovoraComboBox.Items.AddRange(new object[] {
            "Ugovor o radu",
            "Radni odnos uz probni rad",
            "Radni odnos za obavljanje poslova sa povećanim rizikom",
            "Radni odnos sa nepunim radnim vremenom",
            "Radni odnos za rad van prostorija poslodavca",
            "Radni odnos sa kućnim pomoćnim osobljem",
            "Radni odnos sa pripravnikom",
            "Ugovor o obavljanju privremenih i povremenih poslova",
            "Ugovor o delu",
            "Ugovor o stručnom osposobljavanju i usavršavanju",
            "Ugovor o dopunskom radu"});
            this.tipUgovoraComboBox.Location = new System.Drawing.Point(531, 201);
            this.tipUgovoraComboBox.Name = "tipUgovoraComboBox";
            this.tipUgovoraComboBox.Size = new System.Drawing.Size(271, 28);
            this.tipUgovoraComboBox.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tip ugovora:";
            // 
            // osveziBtn
            // 
            this.osveziBtn.Location = new System.Drawing.Point(164, 10);
            this.osveziBtn.Name = "osveziBtn";
            this.osveziBtn.Size = new System.Drawing.Size(147, 49);
            this.osveziBtn.TabIndex = 50;
            this.osveziBtn.Text = "Osveži pregled";
            this.osveziBtn.UseVisualStyleBackColor = true;
            this.osveziBtn.Click += new System.EventHandler(this.osveziBtn_Click);
            // 
            // nazadBtn
            // 
            this.nazadBtn.Location = new System.Drawing.Point(579, 497);
            this.nazadBtn.Name = "nazadBtn";
            this.nazadBtn.Size = new System.Drawing.Size(147, 49);
            this.nazadBtn.TabIndex = 49;
            this.nazadBtn.Text = "Nazad";
            this.nazadBtn.UseVisualStyleBackColor = true;
            this.nazadBtn.Click += new System.EventHandler(this.nazadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Datum zaključivanja:";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(579, 245);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(147, 49);
            this.dodajBtn.TabIndex = 47;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = true;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.Location = new System.Drawing.Point(579, 426);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(147, 49);
            this.obrisiBtn.TabIndex = 46;
            this.obrisiBtn.Text = "Obriši";
            this.obrisiBtn.UseVisualStyleBackColor = true;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // pretraziTipBtn
            // 
            this.pretraziTipBtn.Location = new System.Drawing.Point(248, 382);
            this.pretraziTipBtn.Name = "pretraziTipBtn";
            this.pretraziTipBtn.Size = new System.Drawing.Size(147, 49);
            this.pretraziTipBtn.TabIndex = 45;
            this.pretraziTipBtn.Text = "Pretraži po tipu";
            this.pretraziTipBtn.UseVisualStyleBackColor = true;
            this.pretraziTipBtn.Click += new System.EventHandler(this.pretraziTipBtn_Click);
            // 
            // trajanjeTxt
            // 
            this.trajanjeTxt.Location = new System.Drawing.Point(591, 168);
            this.trajanjeTxt.Name = "trajanjeTxt";
            this.trajanjeTxt.Size = new System.Drawing.Size(170, 27);
            this.trajanjeTxt.TabIndex = 44;
            // 
            // ugovoriLv
            // 
            this.ugovoriLv.HideSelection = false;
            this.ugovoriLv.Location = new System.Drawing.Point(48, 65);
            this.ugovoriLv.Name = "ugovoriLv";
            this.ugovoriLv.Size = new System.Drawing.Size(381, 278);
            this.ugovoriLv.TabIndex = 42;
            this.ugovoriLv.UseCompatibleStateImageBehavior = false;
            this.ugovoriLv.View = System.Windows.Forms.View.List;
            this.ugovoriLv.SelectedIndexChanged += new System.EventHandler(this.ugovoriLv_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Plata:";
            // 
            // plataTxt
            // 
            this.plataTxt.Location = new System.Drawing.Point(591, 135);
            this.plataTxt.Name = "plataTxt";
            this.plataTxt.Size = new System.Drawing.Size(170, 27);
            this.plataTxt.TabIndex = 54;
            // 
            // datumDTP
            // 
            this.datumDTP.CustomFormat = "";
            this.datumDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datumDTP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datumDTP.Location = new System.Drawing.Point(591, 102);
            this.datumDTP.Name = "datumDTP";
            this.datumDTP.Size = new System.Drawing.Size(170, 27);
            this.datumDTP.TabIndex = 56;
            this.datumDTP.Value = new System.DateTime(2021, 9, 15, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Trajanje:";
            // 
            // obrisiTxt
            // 
            this.obrisiTxt.Location = new System.Drawing.Point(567, 393);
            this.obrisiTxt.Name = "obrisiTxt";
            this.obrisiTxt.Size = new System.Drawing.Size(171, 27);
            this.obrisiTxt.TabIndex = 58;
            // 
            // pretraziDTP
            // 
            this.pretraziDTP.CustomFormat = "";
            this.pretraziDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pretraziDTP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pretraziDTP.Location = new System.Drawing.Point(13, 349);
            this.pretraziDTP.Name = "pretraziDTP";
            this.pretraziDTP.Size = new System.Drawing.Size(171, 27);
            this.pretraziDTP.TabIndex = 59;
            this.pretraziDTP.Value = new System.DateTime(2021, 9, 15, 0, 0, 0, 0);
            // 
            // pretraziTipComboBox
            // 
            this.pretraziTipComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pretraziTipComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pretraziTipComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pretraziTipComboBox.FormattingEnabled = true;
            this.pretraziTipComboBox.Items.AddRange(new object[] {
            "Ugovor o radu",
            "Radni odnos uz probni rad",
            "Radni odnos za obavljanje poslova sa povećanim rizikom",
            "Radni odnos sa nepunim radnim vremenom",
            "Radni odnos za rad van prostorija poslodavca",
            "Radni odnos sa kućnim pomoćnim osobljem",
            "Radni odnos sa pripravnikom",
            "Ugovor o obavljanju privremenih i povremenih poslova",
            "Ugovor o delu",
            "Ugovor o stručnom osposobljavanju i usavršavanju",
            "Ugovor o dopunskom radu"});
            this.pretraziTipComboBox.Location = new System.Drawing.Point(190, 348);
            this.pretraziTipComboBox.Name = "pretraziTipComboBox";
            this.pretraziTipComboBox.Size = new System.Drawing.Size(271, 28);
            this.pretraziTipComboBox.TabIndex = 60;
            // 
            // pretraziDatumBtn
            // 
            this.pretraziDatumBtn.Location = new System.Drawing.Point(24, 382);
            this.pretraziDatumBtn.Name = "pretraziDatumBtn";
            this.pretraziDatumBtn.Size = new System.Drawing.Size(147, 49);
            this.pretraziDatumBtn.TabIndex = 61;
            this.pretraziDatumBtn.Text = "Pretraži po datumu";
            this.pretraziDatumBtn.UseVisualStyleBackColor = true;
            this.pretraziDatumBtn.Click += new System.EventHandler(this.pretraziDatumBtn_Click);
            // 
            // pretraziBtn
            // 
            this.pretraziBtn.Location = new System.Drawing.Point(103, 437);
            this.pretraziBtn.Name = "pretraziBtn";
            this.pretraziBtn.Size = new System.Drawing.Size(208, 49);
            this.pretraziBtn.TabIndex = 62;
            this.pretraziBtn.Text = "Pretraži po oba kriterijuma";
            this.pretraziBtn.UseVisualStyleBackColor = true;
            this.pretraziBtn.Click += new System.EventHandler(this.pretraziBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Broj ugovora:";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(591, 69);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(170, 27);
            this.idTxt.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Broj ugovora:";
            // 
            // pretraziIdTxt
            // 
            this.pretraziIdTxt.Location = new System.Drawing.Point(117, 508);
            this.pretraziIdTxt.Name = "pretraziIdTxt";
            this.pretraziIdTxt.Size = new System.Drawing.Size(170, 27);
            this.pretraziIdTxt.TabIndex = 65;
            // 
            // pretraziIdBtn
            // 
            this.pretraziIdBtn.Location = new System.Drawing.Point(293, 497);
            this.pretraziIdBtn.Name = "pretraziIdBtn";
            this.pretraziIdBtn.Size = new System.Drawing.Size(147, 49);
            this.pretraziIdBtn.TabIndex = 67;
            this.pretraziIdBtn.Text = "Pretraži";
            this.pretraziIdBtn.UseVisualStyleBackColor = true;
            this.pretraziIdBtn.Click += new System.EventHandler(this.pretraziIdBtn_Click);
            // 
            // UCUgovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pretraziIdBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pretraziIdTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.pretraziBtn);
            this.Controls.Add(this.pretraziDatumBtn);
            this.Controls.Add(this.pretraziTipComboBox);
            this.Controls.Add(this.pretraziDTP);
            this.Controls.Add(this.obrisiTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datumDTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plataTxt);
            this.Controls.Add(this.tipUgovoraComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.osveziBtn);
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.pretraziTipBtn);
            this.Controls.Add(this.trajanjeTxt);
            this.Controls.Add(this.ugovoriLv);
            this.Name = "UCUgovori";
            this.Size = new System.Drawing.Size(820, 567);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox tipUgovoraComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button osveziBtn;
        private System.Windows.Forms.Button nazadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button obrisiBtn;
        private System.Windows.Forms.Button pretraziTipBtn;
        private System.Windows.Forms.TextBox trajanjeTxt;
        private System.Windows.Forms.ListView ugovoriLv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox plataTxt;
        private System.Windows.Forms.DateTimePicker datumDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox obrisiTxt;
        private System.Windows.Forms.DateTimePicker pretraziDTP;
        private System.Windows.Forms.ComboBox pretraziTipComboBox;
        private System.Windows.Forms.Button pretraziDatumBtn;
        private System.Windows.Forms.Button pretraziBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pretraziIdTxt;
        private System.Windows.Forms.Button pretraziIdBtn;
    }
}
