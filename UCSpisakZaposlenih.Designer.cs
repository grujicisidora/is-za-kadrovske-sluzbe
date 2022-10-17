
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class UCSpisakZaposlenih
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
            this.obrisiBtn = new System.Windows.Forms.Button();
            this.pretraziBtn = new System.Windows.Forms.Button();
            this.obrisiTxt = new System.Windows.Forms.TextBox();
            this.pretraziTxt = new System.Windows.Forms.TextBox();
            this.zaposleniLv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // osveziBtn
            // 
            this.osveziBtn.Location = new System.Drawing.Point(330, 42);
            this.osveziBtn.Name = "osveziBtn";
            this.osveziBtn.Size = new System.Drawing.Size(147, 49);
            this.osveziBtn.TabIndex = 23;
            this.osveziBtn.Text = "Osveži pregled";
            this.osveziBtn.UseVisualStyleBackColor = true;
            this.osveziBtn.Click += new System.EventHandler(this.osveziBtn_Click);
            // 
            // nazadBtn
            // 
            this.nazadBtn.Location = new System.Drawing.Point(591, 469);
            this.nazadBtn.Name = "nazadBtn";
            this.nazadBtn.Size = new System.Drawing.Size(147, 49);
            this.nazadBtn.TabIndex = 22;
            this.nazadBtn.Text = "Nazad";
            this.nazadBtn.UseVisualStyleBackColor = true;
            this.nazadBtn.Click += new System.EventHandler(this.nazadBtn_Click);
            // 
            // obrisiBtn
            // 
            this.obrisiBtn.Location = new System.Drawing.Point(295, 469);
            this.obrisiBtn.Name = "obrisiBtn";
            this.obrisiBtn.Size = new System.Drawing.Size(147, 49);
            this.obrisiBtn.TabIndex = 18;
            this.obrisiBtn.Text = "Obriši";
            this.obrisiBtn.UseVisualStyleBackColor = true;
            this.obrisiBtn.Click += new System.EventHandler(this.obrisiBtn_Click);
            // 
            // pretraziBtn
            // 
            this.pretraziBtn.Location = new System.Drawing.Point(84, 469);
            this.pretraziBtn.Name = "pretraziBtn";
            this.pretraziBtn.Size = new System.Drawing.Size(147, 49);
            this.pretraziBtn.TabIndex = 17;
            this.pretraziBtn.Text = "Pretraži";
            this.pretraziBtn.UseVisualStyleBackColor = true;
            this.pretraziBtn.Click += new System.EventHandler(this.pretraziBtn_Click);
            // 
            // obrisiTxt
            // 
            this.obrisiTxt.Location = new System.Drawing.Point(283, 427);
            this.obrisiTxt.Name = "obrisiTxt";
            this.obrisiTxt.Size = new System.Drawing.Size(171, 27);
            this.obrisiTxt.TabIndex = 14;
            // 
            // pretraziTxt
            // 
            this.pretraziTxt.Location = new System.Drawing.Point(73, 427);
            this.pretraziTxt.Name = "pretraziTxt";
            this.pretraziTxt.Size = new System.Drawing.Size(171, 27);
            this.pretraziTxt.TabIndex = 13;
            // 
            // zaposleniLv
            // 
            this.zaposleniLv.HideSelection = false;
            this.zaposleniLv.Location = new System.Drawing.Point(73, 97);
            this.zaposleniLv.Name = "zaposleniLv";
            this.zaposleniLv.Size = new System.Drawing.Size(665, 324);
            this.zaposleniLv.TabIndex = 12;
            this.zaposleniLv.UseCompatibleStateImageBehavior = false;
            this.zaposleniLv.View = System.Windows.Forms.View.List;
            this.zaposleniLv.SelectedIndexChanged += new System.EventHandler(this.zaposleniLv_SelectedIndexChanged);
            // 
            // UCSpisakZaposlenih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.osveziBtn);
            this.Controls.Add(this.nazadBtn);
            this.Controls.Add(this.obrisiBtn);
            this.Controls.Add(this.pretraziBtn);
            this.Controls.Add(this.obrisiTxt);
            this.Controls.Add(this.pretraziTxt);
            this.Controls.Add(this.zaposleniLv);
            this.Name = "UCSpisakZaposlenih";
            this.Size = new System.Drawing.Size(822, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button osveziBtn;
        private System.Windows.Forms.Button nazadBtn;
        private System.Windows.Forms.Button obrisiBtn;
        private System.Windows.Forms.Button pretraziBtn;
        private System.Windows.Forms.TextBox obrisiTxt;
        private System.Windows.Forms.TextBox pretraziTxt;
        private System.Windows.Forms.ListView zaposleniLv;
    }
}
