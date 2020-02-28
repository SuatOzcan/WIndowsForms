namespace YMS5120_Aritmetik
{
    partial class Form1
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
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btnKalan = new System.Windows.Forms.Button();
            this.btnBirBir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(12, 12);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(145, 37);
            this.btnToplama.TabIndex = 0;
            this.btnToplama.Text = "Toplama";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // btnCikarma
            // 
            this.btnCikarma.Location = new System.Drawing.Point(12, 55);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(145, 37);
            this.btnCikarma.TabIndex = 0;
            this.btnCikarma.Text = "Cikarma";
            this.btnCikarma.UseVisualStyleBackColor = true;
            this.btnCikarma.Click += new System.EventHandler(this.btnCikarma_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(12, 98);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(145, 37);
            this.btnCarpma.TabIndex = 0;
            this.btnCarpma.Text = "Carpma";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(12, 141);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(145, 37);
            this.btnBolme.TabIndex = 0;
            this.btnBolme.Text = "Bolme";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // btnKalan
            // 
            this.btnKalan.Location = new System.Drawing.Point(12, 184);
            this.btnKalan.Name = "btnKalan";
            this.btnKalan.Size = new System.Drawing.Size(145, 37);
            this.btnKalan.TabIndex = 0;
            this.btnKalan.Text = "Bölümden Kalan";
            this.btnKalan.UseVisualStyleBackColor = true;
            this.btnKalan.Click += new System.EventHandler(this.btnKalan_Click);
            // 
            // btnBirBir
            // 
            this.btnBirBir.Location = new System.Drawing.Point(12, 227);
            this.btnBirBir.Name = "btnBirBir";
            this.btnBirBir.Size = new System.Drawing.Size(145, 37);
            this.btnBirBir.TabIndex = 0;
            this.btnBirBir.Text = "Bir Arttır-Eksilt";
            this.btnBirBir.UseVisualStyleBackColor = true;
            this.btnBirBir.Click += new System.EventHandler(this.btnBirBir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 275);
            this.Controls.Add(this.btnBirBir);
            this.Controls.Add(this.btnKalan);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnCikarma);
            this.Controls.Add(this.btnToplama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btnCikarma;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnBolme;
        private System.Windows.Forms.Button btnKalan;
        private System.Windows.Forms.Button btnBirBir;
    }
}

