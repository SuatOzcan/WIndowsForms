namespace YMS5120_MathematicalOperators
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.btnBirinciAlistirma = new System.Windows.Forms.Button();
            this.btnİkinciAlistirma = new System.Windows.Forms.Button();
            this.btnUcuncuAlistirma = new System.Windows.Forms.Button();
            this.btnDorduncuAlistirma = new System.Windows.Forms.Button();
            this.btnBesinciAlistirma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Birinci sayıyı giriniz:";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(3, 17);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(122, 20);
            this.txtSayi1.TabIndex = 1;
            this.txtSayi1.MouseEnter += new System.EventHandler(this.txtSayi1_MouseEnter);
            this.txtSayi1.MouseLeave += new System.EventHandler(this.txtSayi1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lütfen ikinci sayıyı giriniz:";
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(3, 60);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(122, 20);
            this.txtSayi2.TabIndex = 3;
            // 
            // btnBirinciAlistirma
            // 
            this.btnBirinciAlistirma.Location = new System.Drawing.Point(3, 86);
            this.btnBirinciAlistirma.Name = "btnBirinciAlistirma";
            this.btnBirinciAlistirma.Size = new System.Drawing.Size(125, 33);
            this.btnBirinciAlistirma.TabIndex = 4;
            this.btnBirinciAlistirma.Text = "Birinci Alistirma";
            this.btnBirinciAlistirma.UseVisualStyleBackColor = true;
            this.btnBirinciAlistirma.Click += new System.EventHandler(this.btnBirinciAlistirma_Click);
            // 
            // btnİkinciAlistirma
            // 
            this.btnİkinciAlistirma.Location = new System.Drawing.Point(2, 125);
            this.btnİkinciAlistirma.Name = "btnİkinciAlistirma";
            this.btnİkinciAlistirma.Size = new System.Drawing.Size(125, 33);
            this.btnİkinciAlistirma.TabIndex = 4;
            this.btnİkinciAlistirma.Text = "İkinci Alistirma";
            this.btnİkinciAlistirma.UseVisualStyleBackColor = true;
            this.btnİkinciAlistirma.Click += new System.EventHandler(this.btnİkinciAlistirma_Click);
            // 
            // btnUcuncuAlistirma
            // 
            this.btnUcuncuAlistirma.Location = new System.Drawing.Point(2, 164);
            this.btnUcuncuAlistirma.Name = "btnUcuncuAlistirma";
            this.btnUcuncuAlistirma.Size = new System.Drawing.Size(125, 33);
            this.btnUcuncuAlistirma.TabIndex = 4;
            this.btnUcuncuAlistirma.Text = "Ucuncu Alistirma";
            this.btnUcuncuAlistirma.UseVisualStyleBackColor = true;
            this.btnUcuncuAlistirma.Click += new System.EventHandler(this.btnUcuncuAlistirma_Click);
            // 
            // btnDorduncuAlistirma
            // 
            this.btnDorduncuAlistirma.Location = new System.Drawing.Point(2, 203);
            this.btnDorduncuAlistirma.Name = "btnDorduncuAlistirma";
            this.btnDorduncuAlistirma.Size = new System.Drawing.Size(125, 33);
            this.btnDorduncuAlistirma.TabIndex = 4;
            this.btnDorduncuAlistirma.Text = "Dorduncu Alistirma";
            this.btnDorduncuAlistirma.UseVisualStyleBackColor = true;
            this.btnDorduncuAlistirma.Click += new System.EventHandler(this.btnDorduncuAlistirma_Click);
            // 
            // btnBesinciAlistirma
            // 
            this.btnBesinciAlistirma.Location = new System.Drawing.Point(3, 242);
            this.btnBesinciAlistirma.Name = "btnBesinciAlistirma";
            this.btnBesinciAlistirma.Size = new System.Drawing.Size(125, 33);
            this.btnBesinciAlistirma.TabIndex = 4;
            this.btnBesinciAlistirma.Text = "Besinci Alistirma";
            this.btnBesinciAlistirma.UseVisualStyleBackColor = true;
            this.btnBesinciAlistirma.Click += new System.EventHandler(this.btnBesinciAlistirma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 285);
            this.Controls.Add(this.btnBesinciAlistirma);
            this.Controls.Add(this.btnDorduncuAlistirma);
            this.Controls.Add(this.btnUcuncuAlistirma);
            this.Controls.Add(this.btnİkinciAlistirma);
            this.Controls.Add(this.btnBirinciAlistirma);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button btnBirinciAlistirma;
        private System.Windows.Forms.Button btnİkinciAlistirma;
        private System.Windows.Forms.Button btnUcuncuAlistirma;
        private System.Windows.Forms.Button btnDorduncuAlistirma;
        private System.Windows.Forms.Button btnBesinciAlistirma;
    }
}

