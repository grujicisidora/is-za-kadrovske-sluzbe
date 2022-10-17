
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class UCZanimanja
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
            this.label3 = new System.Windows.Forms.Label();
            this.obrUstanovaComboBox = new System.Windows.Forms.ComboBox();
            this.osveziBtn = new System.Windows.Forms.Button();
            this.nazadBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.pretraziBtn = new System.Windows.Forms.Button();
            this.nazivZanimanjaTxt = new System.Windows.Forms.TextBox();
            this.pretraziTxt = new System.Windows.Forms.TextBox();
            this.zanimanjaLv = new System.Windows.Forms.ListView();
            this.smerTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // obrisiComboBox
            // 
            this.obrisiComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.obrisiComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.obrisiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obrisiComboBox.FormattingEnabled = true;
            this.obrisiComboBox.Location = new System.Drawing.Point(241, 395);
            this.obrisiComboBox.Name = "obrisiComboBox";
            this.obrisiComboBox.Size = new System.Drawing.Size(170, 28);
            this.obrisiComboBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Smer:";
            // 
            // obrUstanovaComboBox
            // 
            this.obrUstanovaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.obrUstanovaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.obrUstanovaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obrUstanovaComboBox.FormattingEnabled = true;
            this.obrUstanovaComboBox.Location = new System.Drawing.Point(609, 191);
            this.obrUstanovaComboBox.Name = "obrUstanovaComboBox";
            this.obrUstanovaComboBox.Size = new System.Drawing.Size(194, 28);
            this.obrUstanovaComboBox.TabIndex = 38;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Naziv obrazovne ustanove:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Naziv zanjimanja:";
            // 
            // dodajBtn
            // 
            this.dodajBtn.Location = new System.Drawing.Point(548, 308);
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
            // nazivZanimanjaTxt
            // 
            this.nazivZanimanjaTxt.Location = new System.Drawing.Point(618, 139);
            this.nazivZanimanjaTxt.Name = "nazivZanimanjaTxt";
            this.nazivZanimanjaTxt.Size = new System.Drawing.Size(171, 27);
            this.nazivZanimanjaTxt.TabIndex = 30;
            // 
            // pretraziTxt
            // 
            this.pretraziTxt.Location = new System.Drawing.Point(30, 395);
            this.pretraziTxt.Name = "pretraziTxt";
            this.pretraziTxt.Size = new System.Drawing.Size(171, 27);
            this.pretraziTxt.TabIndex = 29;
            // 
            // zanimanjaLv
            // 
            this.zanimanjaLv.HideSelection = false;
            this.zanimanjaLv.Location = new System.Drawing.Point(30, 65);
            this.zanimanjaLv.Name = "zanimanjaLv";
            this.zanimanjaLv.Size = new System.Drawing.Size(381, 278);
            this.zanimanjaLv.TabIndex = 28;
            this.zanimanjaLv.UseCompatibleStateImageBehavior = false;
            this.zanimanjaLv.View = System.Windows.Forms.View.List;
            this.zanimanjaLv.SelectedIndexChanged += new System.EventHandler(this.zanimanjaLv_SelectedIndexChanged);
            // 
            // smerTxt
            // 
            this.smerTxt.Location = new System.Drawing.Point(618, 247);
            this.smerTxt.Name = "smerTxt";
            this.smerTxt.Size = new System.Drawing.Size(171, 27);
            this.smerTxt.TabIndex = 42;
            // 
            // UCZanimanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.smerTxt);
            this.Controls.Add(this.obrisiComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.obrUstanovaComboBox);
            this.Controls.Add(this.osveziBtn);
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dodajBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.pretraziBtn);
            this.Controls.Add(this.nazivZanimanjaTxt);
            this.Controls.Add(this.pretraziTxt);
            this.Controls.Add(this.zanimanjaLv);
            this.Name = "UCZanimanja";
            this.Size = new System.Drawing.Size(818, 497);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox obrisiComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox obrUstanovaComboBox;
        private System.Windows.Forms.Button osveziBtn;
        private System.Windows.Forms.Button nazadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Button obrisiBtn;
        private System.Windows.Forms.Button pretraziBtn;
        private System.Windows.Forms.TextBox nazivZanimanjaTxt;
        private System.Windows.Forms.TextBox pretraziTxt;
        private System.Windows.Forms.ListView zanimanjaLv;
        private System.Windows.Forms.TextBox smerTxt;
    }
}
