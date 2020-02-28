namespace YMS5120_LoopDo
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
            this.btnWhile1 = new System.Windows.Forms.Button();
            this.btnDoWhile1 = new System.Windows.Forms.Button();
            this.btnWhile2 = new System.Windows.Forms.Button();
            this.btnDoWhile2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnWhile1
            // 
            this.btnWhile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWhile1.Location = new System.Drawing.Point(12, 12);
            this.btnWhile1.Name = "btnWhile1";
            this.btnWhile1.Size = new System.Drawing.Size(122, 48);
            this.btnWhile1.TabIndex = 0;
            this.btnWhile1.Text = "While";
            this.btnWhile1.UseVisualStyleBackColor = true;
            this.btnWhile1.Click += new System.EventHandler(this.btnWhile1_Click);
            // 
            // btnDoWhile1
            // 
            this.btnDoWhile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoWhile1.Location = new System.Drawing.Point(12, 66);
            this.btnDoWhile1.Name = "btnDoWhile1";
            this.btnDoWhile1.Size = new System.Drawing.Size(122, 48);
            this.btnDoWhile1.TabIndex = 0;
            this.btnDoWhile1.Text = "Do While";
            this.btnDoWhile1.UseVisualStyleBackColor = true;
            this.btnDoWhile1.Click += new System.EventHandler(this.btnDoWhile1_Click);
            // 
            // btnWhile2
            // 
            this.btnWhile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWhile2.Location = new System.Drawing.Point(12, 120);
            this.btnWhile2.Name = "btnWhile2";
            this.btnWhile2.Size = new System.Drawing.Size(122, 48);
            this.btnWhile2.TabIndex = 0;
            this.btnWhile2.Text = "While-2";
            this.btnWhile2.UseVisualStyleBackColor = true;
            this.btnWhile2.Click += new System.EventHandler(this.btnWhile2_Click);
            // 
            // btnDoWhile2
            // 
            this.btnDoWhile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoWhile2.Location = new System.Drawing.Point(12, 174);
            this.btnDoWhile2.Name = "btnDoWhile2";
            this.btnDoWhile2.Size = new System.Drawing.Size(122, 48);
            this.btnDoWhile2.TabIndex = 0;
            this.btnDoWhile2.Text = "Do While-2";
            this.btnDoWhile2.UseVisualStyleBackColor = true;
            this.btnDoWhile2.Click += new System.EventHandler(this.btnDoWhile2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(141, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 212);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 233);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDoWhile2);
            this.Controls.Add(this.btnWhile2);
            this.Controls.Add(this.btnDoWhile1);
            this.Controls.Add(this.btnWhile1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWhile1;
        private System.Windows.Forms.Button btnDoWhile1;
        private System.Windows.Forms.Button btnWhile2;
        private System.Windows.Forms.Button btnDoWhile2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

