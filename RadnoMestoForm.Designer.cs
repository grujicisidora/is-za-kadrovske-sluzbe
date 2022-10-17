
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class RadnoMestoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opisTxt = new System.Windows.Forms.RichTextBox();
            this.odeljenjeLbl = new System.Windows.Forms.Label();
            this.poslJedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis: ";
            // 
            // opisTxt
            // 
            this.opisTxt.Location = new System.Drawing.Point(152, 126);
            this.opisTxt.Name = "opisTxt";
            this.opisTxt.ReadOnly = true;
            this.opisTxt.Size = new System.Drawing.Size(517, 157);
            this.opisTxt.TabIndex = 2;
            this.opisTxt.Text = "";
            // 
            // odeljenjeLbl
            // 
            this.odeljenjeLbl.AutoSize = true;
            this.odeljenjeLbl.Location = new System.Drawing.Point(96, 323);
            this.odeljenjeLbl.Name = "odeljenjeLbl";
            this.odeljenjeLbl.Size = new System.Drawing.Size(80, 20);
            this.odeljenjeLbl.TabIndex = 3;
            this.odeljenjeLbl.Text = "Odeljenje: ";
            // 
            // poslJedLbl
            // 
            this.poslJedLbl.AutoSize = true;
            this.poslJedLbl.Location = new System.Drawing.Point(96, 377);
            this.poslJedLbl.Name = "poslJedLbl";
            this.poslJedLbl.Size = new System.Drawing.Size(130, 20);
            this.poslJedLbl.TabIndex = 4;
            this.poslJedLbl.Text = "Poslovna jedinica: ";
            // 
            // RadnoMestoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(755, 445);
            this.Controls.Add(this.poslJedLbl);
            this.Controls.Add(this.odeljenjeLbl);
            this.Controls.Add(this.opisTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RadnoMestoForm";
            this.Text = "Podaci o radnom mestu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox opisTxt;
        private System.Windows.Forms.Label odeljenjeLbl;
        private System.Windows.Forms.Label poslJedLbl;
    }
}