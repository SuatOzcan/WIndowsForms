namespace YMS5120_ArrayList
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
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnek1.Location = new System.Drawing.Point(13, 13);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(401, 71);
            this.btnOrnek1.TabIndex = 0;
            this.btnOrnek1.Text = "ELEMANLARI EKLE";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnek2.Location = new System.Drawing.Point(13, 90);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(401, 71);
            this.btnOrnek2.TabIndex = 0;
            this.btnOrnek2.Text = "METOTLARI GÖSTER";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 188);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOrnek1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.Button btnOrnek2;
    }
}

