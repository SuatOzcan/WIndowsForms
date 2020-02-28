namespace YMS5120_SwitchCase
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
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.txtIkinciGirisAlani = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnKullaniciKontrolu = new System.Windows.Forms.Button();
            this.btnIcIceSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(13, 13);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(167, 20);
            this.txtGirisAlani.TabIndex = 0;
            // 
            // txtIkinciGirisAlani
            // 
            this.txtIkinciGirisAlani.Location = new System.Drawing.Point(13, 39);
            this.txtIkinciGirisAlani.Name = "txtIkinciGirisAlani";
            this.txtIkinciGirisAlani.Size = new System.Drawing.Size(167, 20);
            this.txtIkinciGirisAlani.TabIndex = 0;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(12, 65);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(167, 61);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnKullaniciKontrolu
            // 
            this.btnKullaniciKontrolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciKontrolu.Location = new System.Drawing.Point(13, 132);
            this.btnKullaniciKontrolu.Name = "btnKullaniciKontrolu";
            this.btnKullaniciKontrolu.Size = new System.Drawing.Size(167, 61);
            this.btnKullaniciKontrolu.TabIndex = 1;
            this.btnKullaniciKontrolu.Text = "Kullanıcı Giriş";
            this.btnKullaniciKontrolu.UseVisualStyleBackColor = true;
            this.btnKullaniciKontrolu.Click += new System.EventHandler(this.btnKullaniciKontrolu_Click);
            // 
            // btnIcIceSwitch
            // 
            this.btnIcIceSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIcIceSwitch.Location = new System.Drawing.Point(13, 199);
            this.btnIcIceSwitch.Name = "btnIcIceSwitch";
            this.btnIcIceSwitch.Size = new System.Drawing.Size(167, 61);
            this.btnIcIceSwitch.TabIndex = 1;
            this.btnIcIceSwitch.Text = "İç İçe Switch";
            this.btnIcIceSwitch.UseVisualStyleBackColor = true;
            this.btnIcIceSwitch.Click += new System.EventHandler(this.btnIcIceSwitch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 290);
            this.Controls.Add(this.btnIcIceSwitch);
            this.Controls.Add(this.btnKullaniciKontrolu);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtIkinciGirisAlani);
            this.Controls.Add(this.txtGirisAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGirisAlani;
        private System.Windows.Forms.TextBox txtIkinciGirisAlani;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnKullaniciKontrolu;
        private System.Windows.Forms.Button btnIcIceSwitch;
    }
}

