namespace YMS5120_MathClass
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
            this.btnPi = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.btnFloor = new System.Windows.Forms.Button();
            this.btnCeiling = new System.Windows.Forms.Button();
            this.btnRound = new System.Windows.Forms.Button();
            this.btnTruncate = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnMinDeger = new System.Windows.Forms.Button();
            this.txtBirinci = new System.Windows.Forms.TextBox();
            this.txtIkinci = new System.Windows.Forms.TextBox();
            this.txtUcuncu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPi.Location = new System.Drawing.Point(13, 13);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(250, 35);
            this.btnPi.TabIndex = 0;
            this.btnPi.Text = "PI SAYISI";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnAbs
            // 
            this.btnAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAbs.Location = new System.Drawing.Point(13, 54);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(250, 35);
            this.btnAbs.TabIndex = 0;
            this.btnAbs.Text = "ABS (MUTLAK DEĞER)";
            this.btnAbs.UseVisualStyleBackColor = true;
            this.btnAbs.Click += new System.EventHandler(this.btnAbs_Click);
            // 
            // btnFloor
            // 
            this.btnFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFloor.Location = new System.Drawing.Point(13, 95);
            this.btnFloor.Name = "btnFloor";
            this.btnFloor.Size = new System.Drawing.Size(250, 35);
            this.btnFloor.TabIndex = 0;
            this.btnFloor.Text = "FLOOR";
            this.btnFloor.UseVisualStyleBackColor = true;
            this.btnFloor.Click += new System.EventHandler(this.btnFloor_Click);
            // 
            // btnCeiling
            // 
            this.btnCeiling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCeiling.Location = new System.Drawing.Point(13, 136);
            this.btnCeiling.Name = "btnCeiling";
            this.btnCeiling.Size = new System.Drawing.Size(250, 35);
            this.btnCeiling.TabIndex = 0;
            this.btnCeiling.Text = "CEILING";
            this.btnCeiling.UseVisualStyleBackColor = true;
            this.btnCeiling.Click += new System.EventHandler(this.btnCeiling_Click);
            // 
            // btnRound
            // 
            this.btnRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRound.Location = new System.Drawing.Point(13, 177);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(250, 35);
            this.btnRound.TabIndex = 0;
            this.btnRound.Text = "ROUND";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // btnTruncate
            // 
            this.btnTruncate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTruncate.Location = new System.Drawing.Point(13, 218);
            this.btnTruncate.Name = "btnTruncate";
            this.btnTruncate.Size = new System.Drawing.Size(250, 35);
            this.btnTruncate.TabIndex = 0;
            this.btnTruncate.Text = "TRUNCATE";
            this.btnTruncate.UseVisualStyleBackColor = true;
            this.btnTruncate.Click += new System.EventHandler(this.btnTruncate_Click);
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMax.Location = new System.Drawing.Point(13, 259);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(250, 35);
            this.btnMax.TabIndex = 0;
            this.btnMax.Text = "MAX";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMin.Location = new System.Drawing.Point(13, 300);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(250, 35);
            this.btnMin.TabIndex = 0;
            this.btnMin.Text = "MIN";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnPow
            // 
            this.btnPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPow.Location = new System.Drawing.Point(13, 341);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(250, 35);
            this.btnPow.TabIndex = 0;
            this.btnPow.Text = "POW";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSqrt.Location = new System.Drawing.Point(13, 382);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(250, 35);
            this.btnSqrt.TabIndex = 0;
            this.btnSqrt.Text = "SQRT";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSign.Location = new System.Drawing.Point(13, 423);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(250, 35);
            this.btnSign.TabIndex = 0;
            this.btnSign.Text = "SIGN";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnMinDeger
            // 
            this.btnMinDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinDeger.Location = new System.Drawing.Point(13, 515);
            this.btnMinDeger.Name = "btnMinDeger";
            this.btnMinDeger.Size = new System.Drawing.Size(250, 35);
            this.btnMinDeger.TabIndex = 0;
            this.btnMinDeger.Text = "MINIMUM DEĞER";
            this.btnMinDeger.UseVisualStyleBackColor = true;
            this.btnMinDeger.Click += new System.EventHandler(this.btnMinDeger_Click);
            // 
            // txtBirinci
            // 
            this.txtBirinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirinci.Location = new System.Drawing.Point(46, 464);
            this.txtBirinci.Multiline = true;
            this.txtBirinci.Name = "txtBirinci";
            this.txtBirinci.Size = new System.Drawing.Size(55, 45);
            this.txtBirinci.TabIndex = 1;
            // 
            // txtIkinci
            // 
            this.txtIkinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIkinci.Location = new System.Drawing.Point(107, 464);
            this.txtIkinci.Multiline = true;
            this.txtIkinci.Name = "txtIkinci";
            this.txtIkinci.Size = new System.Drawing.Size(55, 45);
            this.txtIkinci.TabIndex = 1;
            // 
            // txtUcuncu
            // 
            this.txtUcuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUcuncu.Location = new System.Drawing.Point(168, 464);
            this.txtUcuncu.Multiline = true;
            this.txtUcuncu.Name = "txtUcuncu";
            this.txtUcuncu.Size = new System.Drawing.Size(55, 45);
            this.txtUcuncu.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 562);
            this.Controls.Add(this.txtUcuncu);
            this.Controls.Add(this.txtIkinci);
            this.Controls.Add(this.txtBirinci);
            this.Controls.Add(this.btnMinDeger);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnTruncate);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.btnCeiling);
            this.Controls.Add(this.btnFloor);
            this.Controls.Add(this.btnAbs);
            this.Controls.Add(this.btnPi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Button btnFloor;
        private System.Windows.Forms.Button btnCeiling;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Button btnTruncate;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnMinDeger;
        private System.Windows.Forms.TextBox txtBirinci;
        private System.Windows.Forms.TextBox txtIkinci;
        private System.Windows.Forms.TextBox txtUcuncu;
    }
}

