
namespace ISzaKadrovskeSluzbe_PrijemRadnika
{
    partial class PocetnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radniciBtn = new System.Windows.Forms.Button();
            this.meniBtn = new System.Windows.Forms.Button();
            this.izadjiBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radniciBtn
            // 
            this.radniciBtn.Location = new System.Drawing.Point(261, 117);
            this.radniciBtn.Name = "radniciBtn";
            this.radniciBtn.Size = new System.Drawing.Size(253, 63);
            this.radniciBtn.TabIndex = 0;
            this.radniciBtn.Text = "Podaci o zaposlenima";
            this.radniciBtn.UseVisualStyleBackColor = true;
            this.radniciBtn.Click += new System.EventHandler(this.radniciBtn_Click);
            // 
            // meniBtn
            // 
            this.meniBtn.Location = new System.Drawing.Point(261, 213);
            this.meniBtn.Name = "meniBtn";
            this.meniBtn.Size = new System.Drawing.Size(253, 63);
            this.meniBtn.TabIndex = 1;
            this.meniBtn.Text = "Ostali podaci";
            this.meniBtn.UseVisualStyleBackColor = true;
            this.meniBtn.Click += new System.EventHandler(this.meniBtn_Click);
            // 
            // izadjiBtn
            // 
            this.izadjiBtn.Location = new System.Drawing.Point(261, 377);
            this.izadjiBtn.Name = "izadjiBtn";
            this.izadjiBtn.Size = new System.Drawing.Size(253, 63);
            this.izadjiBtn.TabIndex = 2;
            this.izadjiBtn.Text = "Izađi";
            this.izadjiBtn.UseVisualStyleBackColor = true;
            this.izadjiBtn.Click += new System.EventHandler(this.izadjiBtn_Click);
            // 
            // PocetnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.izadjiBtn);
            this.Controls.Add(this.meniBtn);
            this.Controls.Add(this.radniciBtn);
            this.Name = "PocetnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kadrovska služba - prijem radnika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button radniciBtn;
        private System.Windows.Forms.Button meniBtn;
        private System.Windows.Forms.Button izadjiBtn;
    }
}

