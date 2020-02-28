namespace YMS5120_Loop_ForEach
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
            this.btnOrnek4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnek1.Location = new System.Drawing.Point(13, 13);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(288, 44);
            this.btnOrnek1.TabIndex = 0;
            this.btnOrnek1.Text = "Dizi Elemanlarını Listeye At";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnek2.Location = new System.Drawing.Point(13, 63);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(288, 44);
            this.btnOrnek2.TabIndex = 0;
            this.btnOrnek2.Text = "İkiye Bölünenler";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnek3.Location = new System.Drawing.Point(13, 113);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(288, 44);
            this.btnOrnek3.TabIndex = 0;
            this.btnOrnek3.Text = "Listbox1=>Listbox2";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.btnOrnek3_Click);
            // 
            // btnOrnek4
            // 
            this.btnOrnek4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrnek4.Location = new System.Drawing.Point(14, 163);
            this.btnOrnek4.Name = "btnOrnek4";
            this.btnOrnek4.Size = new System.Drawing.Size(288, 44);
            this.btnOrnek4.TabIndex = 0;
            this.btnOrnek4.Text = "Kontrol Değişimi";
            this.btnOrnek4.UseVisualStyleBackColor = true;
            this.btnOrnek4.Click += new System.EventHandler(this.btnOrnek4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(308, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(132, 368);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(446, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(132, 368);
            this.listBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 386);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrnek4);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOrnek1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnOrnek3;
        private System.Windows.Forms.Button btnOrnek4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

