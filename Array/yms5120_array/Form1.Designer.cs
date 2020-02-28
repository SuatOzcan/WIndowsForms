namespace YMS5120_Array
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
            this.btnOrnek3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnek1.Location = new System.Drawing.Point(13, 13);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(259, 36);
            this.btnOrnek1.TabIndex = 0;
            this.btnOrnek1.Text = "SON ELEMANI GÖSTER";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnek2.Location = new System.Drawing.Point(13, 55);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(259, 36);
            this.btnOrnek2.TabIndex = 0;
            this.btnOrnek2.Text = "RASTGELE ELEMAN GÖSTER";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnek3.Location = new System.Drawing.Point(13, 97);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(259, 36);
            this.btnOrnek3.TabIndex = 0;
            this.btnOrnek3.Text = "ELEMANLARI LİSTBOX\'A EKLE";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.btnOrnek3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 134);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOrnek1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnOrnek3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

