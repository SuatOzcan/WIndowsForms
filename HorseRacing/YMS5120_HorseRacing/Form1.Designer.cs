namespace YMS5120_HorseRacing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnYarisiBaslat = new System.Windows.Forms.Button();
            this.btnYarisiSifirla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBitis = new System.Windows.Forms.Label();
            this.pcbBirinciAt = new System.Windows.Forms.PictureBox();
            this.pcbIkinciAt = new System.Windows.Forms.PictureBox();
            this.pcbUcuncuAt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBirinciAt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIkinciAt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUcuncuAt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 10);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 10);
            this.label2.TabIndex = 0;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.BackColor = System.Drawing.Color.White;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(12, 9);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 20);
            this.lblDurum.TabIndex = 1;
            // 
            // btnYarisiBaslat
            // 
            this.btnYarisiBaslat.BackColor = System.Drawing.Color.Green;
            this.btnYarisiBaslat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYarisiBaslat.ForeColor = System.Drawing.Color.White;
            this.btnYarisiBaslat.Location = new System.Drawing.Point(272, 12);
            this.btnYarisiBaslat.Name = "btnYarisiBaslat";
            this.btnYarisiBaslat.Size = new System.Drawing.Size(144, 39);
            this.btnYarisiBaslat.TabIndex = 2;
            this.btnYarisiBaslat.Text = "Yarışı Başlat";
            this.btnYarisiBaslat.UseVisualStyleBackColor = false;
            this.btnYarisiBaslat.Click += new System.EventHandler(this.btnYarisiBaslat_Click);
            // 
            // btnYarisiSifirla
            // 
            this.btnYarisiSifirla.BackColor = System.Drawing.Color.Green;
            this.btnYarisiSifirla.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYarisiSifirla.ForeColor = System.Drawing.Color.White;
            this.btnYarisiSifirla.Location = new System.Drawing.Point(422, 12);
            this.btnYarisiSifirla.Name = "btnYarisiSifirla";
            this.btnYarisiSifirla.Size = new System.Drawing.Size(140, 39);
            this.btnYarisiSifirla.TabIndex = 2;
            this.btnYarisiSifirla.Text = "Yarışı Sıfırla";
            this.btnYarisiSifirla.UseVisualStyleBackColor = false;
            this.btnYarisiSifirla.Click += new System.EventHandler(this.btnYarisiSifirla_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBitis
            // 
            this.lblBitis.BackColor = System.Drawing.Color.White;
            this.lblBitis.Location = new System.Drawing.Point(513, 87);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(10, 277);
            this.lblBitis.TabIndex = 3;
            // 
            // pcbBirinciAt
            // 
            this.pcbBirinciAt.Image = ((System.Drawing.Image)(resources.GetObject("pcbBirinciAt.Image")));
            this.pcbBirinciAt.Location = new System.Drawing.Point(16, 73);
            this.pcbBirinciAt.Name = "pcbBirinciAt";
            this.pcbBirinciAt.Size = new System.Drawing.Size(68, 82);
            this.pcbBirinciAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBirinciAt.TabIndex = 4;
            this.pcbBirinciAt.TabStop = false;
            // 
            // pcbIkinciAt
            // 
            this.pcbIkinciAt.Image = ((System.Drawing.Image)(resources.GetObject("pcbIkinciAt.Image")));
            this.pcbIkinciAt.Location = new System.Drawing.Point(16, 177);
            this.pcbIkinciAt.Name = "pcbIkinciAt";
            this.pcbIkinciAt.Size = new System.Drawing.Size(68, 82);
            this.pcbIkinciAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIkinciAt.TabIndex = 4;
            this.pcbIkinciAt.TabStop = false;
            // 
            // pcbUcuncuAt
            // 
            this.pcbUcuncuAt.Image = ((System.Drawing.Image)(resources.GetObject("pcbUcuncuAt.Image")));
            this.pcbUcuncuAt.Location = new System.Drawing.Point(16, 275);
            this.pcbUcuncuAt.Name = "pcbUcuncuAt";
            this.pcbUcuncuAt.Size = new System.Drawing.Size(68, 82);
            this.pcbUcuncuAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUcuncuAt.TabIndex = 4;
            this.pcbUcuncuAt.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(564, 391);
            this.Controls.Add(this.pcbUcuncuAt);
            this.Controls.Add(this.pcbIkinciAt);
            this.Controls.Add(this.pcbBirinciAt);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.btnYarisiSifirla);
            this.Controls.Add(this.btnYarisiBaslat);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbBirinciAt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIkinciAt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUcuncuAt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnYarisiBaslat;
        private System.Windows.Forms.Button btnYarisiSifirla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.PictureBox pcbBirinciAt;
        private System.Windows.Forms.PictureBox pcbIkinciAt;
        private System.Windows.Forms.PictureBox pcbUcuncuAt;
    }
}

