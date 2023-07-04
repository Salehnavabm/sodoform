namespace sodoform
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
            this.sudokuTextBox = new System.Windows.Forms.TextBox();
            this.solutionTextBox = new System.Windows.Forms.TextBox();
            this.SolveSudok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sudokuTextBox
            // 
            this.sudokuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sudokuTextBox.Location = new System.Drawing.Point(12, 46);
            this.sudokuTextBox.Multiline = true;
            this.sudokuTextBox.Name = "sudokuTextBox";
            this.sudokuTextBox.Size = new System.Drawing.Size(200, 199);
            this.sudokuTextBox.TabIndex = 1;
            this.sudokuTextBox.TextChanged += new System.EventHandler(this.sudokuTextBox_TextChanged);
            // 
            // solutionTextBox
            // 
            this.solutionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.solutionTextBox.Location = new System.Drawing.Point(294, 46);
            this.solutionTextBox.Multiline = true;
            this.solutionTextBox.Name = "solutionTextBox";
            this.solutionTextBox.Size = new System.Drawing.Size(185, 199);
            this.solutionTextBox.TabIndex = 2;
            this.solutionTextBox.TextChanged += new System.EventHandler(this.solutionTextBox_TextChanged);
            // 
            // SolveSudok
            // 
            this.SolveSudok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SolveSudok.Location = new System.Drawing.Point(16, 251);
            this.SolveSudok.Name = "SolveSudok";
            this.SolveSudok.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SolveSudok.Size = new System.Drawing.Size(91, 31);
            this.SolveSudok.TabIndex = 3;
            this.SolveSudok.Text = "حل سودوکو";
            this.SolveSudok.UseVisualStyleBackColor = true;
            this.SolveSudok.Click += new System.EventHandler(this.SolveSudok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "سودوکو مورد نظر خود را وارد کنید ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(309, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "حل سودوکو وارد شده";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(394, 251);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Location = new System.Drawing.Point(204, 251);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(91, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "راهنما";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 286);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SolveSudok);
            this.Controls.Add(this.solutionTextBox);
            this.Controls.Add(this.sudokuTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sudokuTextBox;
        private System.Windows.Forms.TextBox solutionTextBox;
        private System.Windows.Forms.Button SolveSudok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

