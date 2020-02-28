namespace YMS5120_Metot
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
            this.txtOrnekIki = new System.Windows.Forms.TextBox();
            this.btnCiftTek = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.btnMetin = new System.Windows.Forms.Button();
            this.btnDizi = new System.Windows.Forms.Button();
            this.btnRenkYakala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToplama
            // 
            this.btnToplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplama.Location = new System.Drawing.Point(13, 13);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(259, 39);
            this.btnToplama.TabIndex = 0;
            this.btnToplama.Text = "Toplama Yap";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // txtOrnekIki
            // 
            this.txtOrnekIki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOrnekIki.Location = new System.Drawing.Point(13, 59);
            this.txtOrnekIki.Name = "txtOrnekIki";
            this.txtOrnekIki.Size = new System.Drawing.Size(259, 29);
            this.txtOrnekIki.TabIndex = 1;
            // 
            // btnCiftTek
            // 
            this.btnCiftTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiftTek.Location = new System.Drawing.Point(13, 86);
            this.btnCiftTek.Name = "btnCiftTek";
            this.btnCiftTek.Size = new System.Drawing.Size(259, 35);
            this.btnCiftTek.TabIndex = 2;
            this.btnCiftTek.Text = "Çift Mi Tek Mi?";
            this.btnCiftTek.UseVisualStyleBackColor = true;
            this.btnCiftTek.Click += new System.EventHandler(this.btnCiftTek_Click);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(13, 128);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(259, 29);
            this.txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(13, 154);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(259, 29);
            this.txtSoyad.TabIndex = 3;
            // 
            // btnMetin
            // 
            this.btnMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetin.Location = new System.Drawing.Point(13, 181);
            this.btnMetin.Name = "btnMetin";
            this.btnMetin.Size = new System.Drawing.Size(259, 34);
            this.btnMetin.TabIndex = 4;
            this.btnMetin.Text = "Metinsel Değişiklik";
            this.btnMetin.UseVisualStyleBackColor = true;
            this.btnMetin.Click += new System.EventHandler(this.btnMetin_Click);
            // 
            // btnDizi
            // 
            this.btnDizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDizi.Location = new System.Drawing.Point(13, 221);
            this.btnDizi.Name = "btnDizi";
            this.btnDizi.Size = new System.Drawing.Size(259, 34);
            this.btnDizi.TabIndex = 4;
            this.btnDizi.Text = "Dizi İşleme";
            this.btnDizi.UseVisualStyleBackColor = true;
            this.btnDizi.Click += new System.EventHandler(this.btnDizi_Click);
            // 
            // btnRenkYakala
            // 
            this.btnRenkYakala.BackColor = System.Drawing.Color.Teal;
            this.btnRenkYakala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenkYakala.Location = new System.Drawing.Point(13, 261);
            this.btnRenkYakala.Name = "btnRenkYakala";
            this.btnRenkYakala.Size = new System.Drawing.Size(259, 34);
            this.btnRenkYakala.TabIndex = 4;
            this.btnRenkYakala.Text = "Rengi Yakala";
            this.btnRenkYakala.UseVisualStyleBackColor = false;
            this.btnRenkYakala.Click += new System.EventHandler(this.btnRenkYakala_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 320);
            this.Controls.Add(this.btnRenkYakala);
            this.Controls.Add(this.btnDizi);
            this.Controls.Add(this.btnMetin);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnCiftTek);
            this.Controls.Add(this.txtOrnekIki);
            this.Controls.Add(this.btnToplama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.TextBox txtOrnekIki;
        private System.Windows.Forms.Button btnCiftTek;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Button btnMetin;
        private System.Windows.Forms.Button btnDizi;
        private System.Windows.Forms.Button btnRenkYakala;
    }
}

