namespace Sayisal
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
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t6 = new System.Windows.Forms.TextBox();
            this.btnCekilis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBilet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t1.Location = new System.Drawing.Point(16, 55);
            this.t1.Multiline = true;
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(94, 77);
            this.t1.TabIndex = 2;
            this.t1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t2
            // 
            this.t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t2.Location = new System.Drawing.Point(118, 55);
            this.t2.Multiline = true;
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(94, 77);
            this.t2.TabIndex = 2;
            this.t2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t3
            // 
            this.t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t3.Location = new System.Drawing.Point(218, 55);
            this.t3.Multiline = true;
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(94, 77);
            this.t3.TabIndex = 2;
            this.t3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t4
            // 
            this.t4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t4.Location = new System.Drawing.Point(318, 55);
            this.t4.Multiline = true;
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(94, 77);
            this.t4.TabIndex = 2;
            this.t4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t5
            // 
            this.t5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t5.Location = new System.Drawing.Point(420, 55);
            this.t5.Multiline = true;
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(94, 77);
            this.t5.TabIndex = 2;
            this.t5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t6
            // 
            this.t6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.t6.Location = new System.Drawing.Point(520, 55);
            this.t6.Multiline = true;
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(94, 77);
            this.t6.TabIndex = 2;
            this.t6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCekilis
            // 
            this.btnCekilis.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCekilis.Location = new System.Drawing.Point(16, 150);
            this.btnCekilis.Name = "btnCekilis";
            this.btnCekilis.Size = new System.Drawing.Size(598, 86);
            this.btnCekilis.TabIndex = 3;
            this.btnCekilis.Text = "Çekilişi Başlat";
            this.btnCekilis.UseVisualStyleBackColor = true;
            this.btnCekilis.Click += new System.EventHandler(this.btnCekilis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sizin Biletiniz:";
            // 
            // lblBilet
            // 
            this.lblBilet.AutoSize = true;
            this.lblBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilet.Location = new System.Drawing.Point(140, 20);
            this.lblBilet.Name = "lblBilet";
            this.lblBilet.Size = new System.Drawing.Size(0, 20);
            this.lblBilet.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 257);
            this.Controls.Add(this.lblBilet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCekilis);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.Button btnCekilis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBilet;
    }
}

