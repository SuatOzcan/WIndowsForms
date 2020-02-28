namespace YMS5120_Konus
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
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.btnKonus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(12, 12);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(347, 30);
            this.txtKelime.TabIndex = 0;
            // 
            // btnKonus
            // 
            this.btnKonus.Location = new System.Drawing.Point(12, 48);
            this.btnKonus.Name = "btnKonus";
            this.btnKonus.Size = new System.Drawing.Size(347, 38);
            this.btnKonus.TabIndex = 1;
            this.btnKonus.Text = "KONUŞ";
            this.btnKonus.UseVisualStyleBackColor = true;
            this.btnKonus.Click += new System.EventHandler(this.btnKonus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 99);
            this.Controls.Add(this.btnKonus);
            this.Controls.Add(this.txtKelime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Button btnKonus;
    }
}

