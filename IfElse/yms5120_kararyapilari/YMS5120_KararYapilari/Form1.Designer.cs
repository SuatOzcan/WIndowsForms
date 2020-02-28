namespace YMS5120_KararYapilari
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
            this.btnAdminKontrolu = new System.Windows.Forms.Button();
            this.btnNotKontrolu = new System.Windows.Forms.Button();
            this.btnCiftTekKontrolu = new System.Windows.Forms.Button();
            this.btnDegerKontrolu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(13, 13);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(319, 20);
            this.txtGirisAlani.TabIndex = 0;
            // 
            // btnAdminKontrolu
            // 
            this.btnAdminKontrolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminKontrolu.Location = new System.Drawing.Point(13, 40);
            this.btnAdminKontrolu.Name = "btnAdminKontrolu";
            this.btnAdminKontrolu.Size = new System.Drawing.Size(319, 70);
            this.btnAdminKontrolu.TabIndex = 1;
            this.btnAdminKontrolu.Text = "ADMİN KONTROLÜ";
            this.btnAdminKontrolu.UseVisualStyleBackColor = true;
            this.btnAdminKontrolu.Click += new System.EventHandler(this.btnAdminKontrolu_Click);
            // 
            // btnNotKontrolu
            // 
            this.btnNotKontrolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotKontrolu.Location = new System.Drawing.Point(12, 116);
            this.btnNotKontrolu.Name = "btnNotKontrolu";
            this.btnNotKontrolu.Size = new System.Drawing.Size(319, 70);
            this.btnNotKontrolu.TabIndex = 2;
            this.btnNotKontrolu.Text = "NOT KONTROLÜ";
            this.btnNotKontrolu.UseVisualStyleBackColor = true;
            this.btnNotKontrolu.Click += new System.EventHandler(this.btnNotKontrolu_Click);
            // 
            // btnCiftTekKontrolu
            // 
            this.btnCiftTekKontrolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiftTekKontrolu.Location = new System.Drawing.Point(12, 192);
            this.btnCiftTekKontrolu.Name = "btnCiftTekKontrolu";
            this.btnCiftTekKontrolu.Size = new System.Drawing.Size(319, 70);
            this.btnCiftTekKontrolu.TabIndex = 2;
            this.btnCiftTekKontrolu.Text = "ÇİFT-TEK KONTROLÜ";
            this.btnCiftTekKontrolu.UseVisualStyleBackColor = true;
            this.btnCiftTekKontrolu.Click += new System.EventHandler(this.btnCiftTekKontrolu_Click);
            // 
            // btnDegerKontrolu
            // 
            this.btnDegerKontrolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegerKontrolu.Location = new System.Drawing.Point(13, 268);
            this.btnDegerKontrolu.Name = "btnDegerKontrolu";
            this.btnDegerKontrolu.Size = new System.Drawing.Size(319, 70);
            this.btnDegerKontrolu.TabIndex = 2;
            this.btnDegerKontrolu.Text = "DEĞER KONTROLÜ";
            this.btnDegerKontrolu.UseVisualStyleBackColor = true;
            this.btnDegerKontrolu.Click += new System.EventHandler(this.btnDegerKontrolu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 341);
            this.Controls.Add(this.btnDegerKontrolu);
            this.Controls.Add(this.btnCiftTekKontrolu);
            this.Controls.Add(this.btnNotKontrolu);
            this.Controls.Add(this.btnAdminKontrolu);
            this.Controls.Add(this.txtGirisAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGirisAlani;
        private System.Windows.Forms.Button btnAdminKontrolu;
        private System.Windows.Forms.Button btnNotKontrolu;
        private System.Windows.Forms.Button btnCiftTekKontrolu;
        private System.Windows.Forms.Button btnDegerKontrolu;
    }
}

