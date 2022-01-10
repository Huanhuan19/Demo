namespace WindowsFormsApp3
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
            this.button1 = new System.Windows.Forms.Button();
            this.row = new System.Windows.Forms.TextBox();
            this.col = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rows = new System.Windows.Forms.TextBox();
            this.cols = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MultiCell = new System.Windows.Forms.TextBox();
            this.SetValue = new System.Windows.Forms.TextBox();
            this.setCol = new System.Windows.Forms.TextBox();
            this.setRow = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(12, 37);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(100, 22);
            this.row.TabIndex = 3;
            this.row.Text = "1";
            // 
            // col
            // 
            this.col.Location = new System.Drawing.Point(137, 37);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(100, 22);
            this.col.TabIndex = 4;
            this.col.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // rows
            // 
            this.rows.Location = new System.Drawing.Point(12, 112);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(100, 22);
            this.rows.TabIndex = 6;
            this.rows.Text = "1";
            // 
            // cols
            // 
            this.cols.Location = new System.Drawing.Point(137, 112);
            this.cols.Name = "cols";
            this.cols.Size = new System.Drawing.Size(100, 22);
            this.cols.TabIndex = 7;
            this.cols.Text = "1";
            this.cols.TextChanged += new System.EventHandler(this.cols_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 105);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "reads";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(646, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // MultiCell
            // 
            this.MultiCell.Location = new System.Drawing.Point(12, 157);
            this.MultiCell.Multiline = true;
            this.MultiCell.Name = "MultiCell";
            this.MultiCell.Size = new System.Drawing.Size(371, 174);
            this.MultiCell.TabIndex = 11;
            // 
            // SetValue
            // 
            this.SetValue.Location = new System.Drawing.Point(417, 384);
            this.SetValue.Name = "SetValue";
            this.SetValue.Size = new System.Drawing.Size(100, 22);
            this.SetValue.TabIndex = 12;
            // 
            // setCol
            // 
            this.setCol.Location = new System.Drawing.Point(137, 384);
            this.setCol.Name = "setCol";
            this.setCol.Size = new System.Drawing.Size(100, 22);
            this.setCol.TabIndex = 15;
            this.setCol.Text = "1";
            // 
            // setRow
            // 
            this.setRow.Location = new System.Drawing.Point(12, 384);
            this.setRow.Name = "setRow";
            this.setRow.Size = new System.Drawing.Size(100, 22);
            this.setRow.TabIndex = 14;
            this.setRow.Text = "1";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(265, 377);
            this.btnSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(118, 36);
            this.btnSet.TabIndex = 13;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 713);
            this.Controls.Add(this.setCol);
            this.Controls.Add(this.setRow);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.SetValue);
            this.Controls.Add(this.MultiCell);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cols);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.col);
            this.Controls.Add(this.row);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox row;
        private System.Windows.Forms.TextBox col;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rows;
        private System.Windows.Forms.TextBox cols;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox MultiCell;
        private System.Windows.Forms.TextBox SetValue;
        private System.Windows.Forms.TextBox setCol;
        private System.Windows.Forms.TextBox setRow;
        private System.Windows.Forms.Button btnSet;
    }
}

