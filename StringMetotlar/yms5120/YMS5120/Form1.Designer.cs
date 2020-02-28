namespace YMS5120
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.benEndsWith = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnToLowerToUpper = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.btnToCharArray = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(13, 13);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(206, 20);
            this.txtGirisAlani.TabIndex = 0;
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompare.Location = new System.Drawing.Point(13, 40);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(206, 33);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "COMPARE TO";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnContains
            // 
            this.btnContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContains.Location = new System.Drawing.Point(13, 79);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(206, 33);
            this.btnContains.TabIndex = 1;
            this.btnContains.Text = "CONTAINS";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartsWith.Location = new System.Drawing.Point(12, 118);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(206, 33);
            this.btnStartsWith.TabIndex = 1;
            this.btnStartsWith.Text = "STARTSWITH";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // benEndsWith
            // 
            this.benEndsWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.benEndsWith.Location = new System.Drawing.Point(12, 157);
            this.benEndsWith.Name = "benEndsWith";
            this.benEndsWith.Size = new System.Drawing.Size(206, 33);
            this.benEndsWith.TabIndex = 1;
            this.benEndsWith.Text = "ENDSWITH";
            this.benEndsWith.UseVisualStyleBackColor = true;
            this.benEndsWith.Click += new System.EventHandler(this.benEndsWith_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIndexOf.Location = new System.Drawing.Point(13, 196);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(206, 33);
            this.btnIndexOf.TabIndex = 1;
            this.btnIndexOf.Text = "INDEXOF";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLastIndexOf.Location = new System.Drawing.Point(12, 235);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(206, 33);
            this.btnLastIndexOf.TabIndex = 1;
            this.btnLastIndexOf.Text = "LASTINDEXOF";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Location = new System.Drawing.Point(13, 270);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(206, 33);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReplace.Location = new System.Drawing.Point(13, 309);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(206, 33);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "REPLACE";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSplit.Location = new System.Drawing.Point(12, 348);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(206, 33);
            this.btnSplit.TabIndex = 1;
            this.btnSplit.Text = "SPLIT";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.Location = new System.Drawing.Point(12, 387);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(206, 33);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnToLowerToUpper
            // 
            this.btnToLowerToUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToLowerToUpper.Location = new System.Drawing.Point(13, 426);
            this.btnToLowerToUpper.Name = "btnToLowerToUpper";
            this.btnToLowerToUpper.Size = new System.Drawing.Size(206, 33);
            this.btnToLowerToUpper.TabIndex = 1;
            this.btnToLowerToUpper.Text = "TOLOWER-TOUPPER";
            this.btnToLowerToUpper.UseVisualStyleBackColor = true;
            this.btnToLowerToUpper.Click += new System.EventHandler(this.btnToLowerToUpper_Click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubstring.Location = new System.Drawing.Point(12, 465);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(206, 33);
            this.btnSubstring.TabIndex = 1;
            this.btnSubstring.Text = "SUBSTRING";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // btnToCharArray
            // 
            this.btnToCharArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToCharArray.Location = new System.Drawing.Point(13, 505);
            this.btnToCharArray.Name = "btnToCharArray";
            this.btnToCharArray.Size = new System.Drawing.Size(205, 34);
            this.btnToCharArray.TabIndex = 2;
            this.btnToCharArray.Text = "TO CHAR ARRAY";
            this.btnToCharArray.UseVisualStyleBackColor = true;
            this.btnToCharArray.Click += new System.EventHandler(this.btnToCharArray_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrim.Location = new System.Drawing.Point(12, 545);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(205, 34);
            this.btnTrim.TabIndex = 2;
            this.btnTrim.Text = "TRIM";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 578);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnToCharArray);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.btnToLowerToUpper);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.benEndsWith);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtGirisAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGirisAlani;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.Button benEndsWith;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnToLowerToUpper;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.Button btnToCharArray;
        private System.Windows.Forms.Button btnTrim;
    }
}

