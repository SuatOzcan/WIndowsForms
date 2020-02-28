namespace YMS5120_Arrays
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnLastIndex = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(13, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(220, 39);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "ARRAY.CLEAR()";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCopy.Location = new System.Drawing.Point(13, 58);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(220, 39);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "ARRAY.COPY()";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIndexOf.Location = new System.Drawing.Point(13, 103);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(220, 39);
            this.btnIndexOf.TabIndex = 0;
            this.btnIndexOf.Text = "ARRAY.INDEXOF()";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnLastIndex
            // 
            this.btnLastIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLastIndex.Location = new System.Drawing.Point(13, 148);
            this.btnLastIndex.Name = "btnLastIndex";
            this.btnLastIndex.Size = new System.Drawing.Size(220, 39);
            this.btnLastIndex.TabIndex = 0;
            this.btnLastIndex.Text = "ARRAY.LASTINDEXOF()";
            this.btnLastIndex.UseVisualStyleBackColor = true;
            this.btnLastIndex.Click += new System.EventHandler(this.btnLastIndex_Click);
            // 
            // btnResize
            // 
            this.btnResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResize.Location = new System.Drawing.Point(13, 193);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(220, 39);
            this.btnResize.TabIndex = 0;
            this.btnResize.Text = "ARAY.RESIZE()";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSort.Location = new System.Drawing.Point(13, 238);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(220, 39);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "ARRAY.SORT()";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReverse.Location = new System.Drawing.Point(13, 283);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(220, 39);
            this.btnReverse.TabIndex = 0;
            this.btnReverse.Text = "ARRAY.REVERSE()";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 340);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnLastIndex);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnLastIndex;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReverse;
    }
}

