namespace YMS5120_TryCatch
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
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnHataYönetimliOnayla = new System.Windows.Forms.Button();
            this.btnDetaylıOnayla = new System.Windows.Forms.Button();
            this.btnFinallyOnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen telefon numaranızı giriniz:";
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(5, 38);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(451, 20);
            this.txtGirisAlani.TabIndex = 1;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(5, 65);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(451, 36);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "ONAYLA-HATA YÖNETİMSİZ";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnHataYönetimliOnayla
            // 
            this.btnHataYönetimliOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHataYönetimliOnayla.Location = new System.Drawing.Point(5, 107);
            this.btnHataYönetimliOnayla.Name = "btnHataYönetimliOnayla";
            this.btnHataYönetimliOnayla.Size = new System.Drawing.Size(451, 36);
            this.btnHataYönetimliOnayla.TabIndex = 2;
            this.btnHataYönetimliOnayla.Text = "ONAYLA-HATA YÖNETİMLİ";
            this.btnHataYönetimliOnayla.UseVisualStyleBackColor = true;
            this.btnHataYönetimliOnayla.Click += new System.EventHandler(this.btnHataYönetimliOnayla_Click);
            // 
            // btnDetaylıOnayla
            // 
            this.btnDetaylıOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetaylıOnayla.Location = new System.Drawing.Point(5, 149);
            this.btnDetaylıOnayla.Name = "btnDetaylıOnayla";
            this.btnDetaylıOnayla.Size = new System.Drawing.Size(451, 36);
            this.btnDetaylıOnayla.TabIndex = 2;
            this.btnDetaylıOnayla.Text = "ONAYLA-HATA YÖNETİMLİ(SİSTEM MESAJI)";
            this.btnDetaylıOnayla.UseVisualStyleBackColor = true;
            this.btnDetaylıOnayla.Click += new System.EventHandler(this.btnDetaylıOnayla_Click);
            // 
            // btnFinallyOnayla
            // 
            this.btnFinallyOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFinallyOnayla.Location = new System.Drawing.Point(5, 191);
            this.btnFinallyOnayla.Name = "btnFinallyOnayla";
            this.btnFinallyOnayla.Size = new System.Drawing.Size(451, 36);
            this.btnFinallyOnayla.TabIndex = 2;
            this.btnFinallyOnayla.Text = "ONAYLA-HATA YÖNETİMLİ(FINALLY BLOĞU)";
            this.btnFinallyOnayla.UseVisualStyleBackColor = true;
            this.btnFinallyOnayla.Click += new System.EventHandler(this.btnFinallyOnayla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 315);
            this.Controls.Add(this.btnFinallyOnayla);
            this.Controls.Add(this.btnDetaylıOnayla);
            this.Controls.Add(this.btnHataYönetimliOnayla);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtGirisAlani);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGirisAlani;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnHataYönetimliOnayla;
        private System.Windows.Forms.Button btnDetaylıOnayla;
        private System.Windows.Forms.Button btnFinallyOnayla;
    }
}

