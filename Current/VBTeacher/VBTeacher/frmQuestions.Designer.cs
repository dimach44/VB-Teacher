namespace VBTeacher
{
    partial class frmQuestions
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
            this.rbtnAns0 = new System.Windows.Forms.RadioButton();
            this.rbtnAns1 = new System.Windows.Forms.RadioButton();
            this.rbtnAns2 = new System.Windows.Forms.RadioButton();
            this.rbtnAns3 = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnHelpMe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnAns0
            // 
            this.rbtnAns0.Checked = true;
            this.rbtnAns0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAns0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnAns0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAns0.Location = new System.Drawing.Point(26, 87);
            this.rbtnAns0.Name = "rbtnAns0";
            this.rbtnAns0.Size = new System.Drawing.Size(352, 45);
            this.rbtnAns0.TabIndex = 0;
            this.rbtnAns0.TabStop = true;
            this.rbtnAns0.Text = "Answer 1";
            this.rbtnAns0.UseVisualStyleBackColor = true;
            // 
            // rbtnAns1
            // 
            this.rbtnAns1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAns1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnAns1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAns1.Location = new System.Drawing.Point(26, 138);
            this.rbtnAns1.Name = "rbtnAns1";
            this.rbtnAns1.Size = new System.Drawing.Size(352, 45);
            this.rbtnAns1.TabIndex = 1;
            this.rbtnAns1.Text = "Answer 2";
            this.rbtnAns1.UseVisualStyleBackColor = true;
            // 
            // rbtnAns2
            // 
            this.rbtnAns2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAns2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnAns2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAns2.Location = new System.Drawing.Point(26, 189);
            this.rbtnAns2.Name = "rbtnAns2";
            this.rbtnAns2.Size = new System.Drawing.Size(352, 45);
            this.rbtnAns2.TabIndex = 2;
            this.rbtnAns2.Text = "Answer 3";
            this.rbtnAns2.UseVisualStyleBackColor = true;
            // 
            // rbtnAns3
            // 
            this.rbtnAns3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnAns3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnAns3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAns3.Location = new System.Drawing.Point(26, 240);
            this.rbtnAns3.Name = "rbtnAns3";
            this.rbtnAns3.Size = new System.Drawing.Size(352, 45);
            this.rbtnAns3.TabIndex = 3;
            this.rbtnAns3.Text = "Answer 4";
            this.rbtnAns3.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(9, 16);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(340, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(86, 24);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // txtSrc
            // 
            this.txtSrc.AcceptsReturn = true;
            this.txtSrc.AcceptsTab = true;
            this.txtSrc.BackColor = System.Drawing.Color.White;
            this.txtSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSrc.ForeColor = System.Drawing.Color.Black;
            this.txtSrc.Location = new System.Drawing.Point(6, 19);
            this.txtSrc.Multiline = true;
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSrc.Size = new System.Drawing.Size(328, 266);
            this.txtSrc.TabIndex = 5;
            this.txtSrc.Text = "Imports System\r\n\r\nModule main\r\n    Sub Main()\r\n        Console.WriteLine(\"Hello W" +
    "orld\")\r\n        Console.ReadLine()\r\n    End Sub\r\nEnd Module";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbtnAns0);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblQuestion);
            this.groupBox1.Controls.Add(this.rbtnAns3);
            this.groupBox1.Controls.Add(this.rbtnAns1);
            this.groupBox1.Controls.Add(this.rbtnAns2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 320);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(6, 291);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(372, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRun);
            this.groupBox2.Controls.Add(this.txtSrc);
            this.groupBox2.Location = new System.Drawing.Point(402, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 320);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Work Pad:";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.Control;
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.ForeColor = System.Drawing.Color.Black;
            this.btnRun.Location = new System.Drawing.Point(6, 291);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(328, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run Code";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnHelpMe
            // 
            this.btnHelpMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpMe.Location = new System.Drawing.Point(12, 5);
            this.btnHelpMe.Name = "btnHelpMe";
            this.btnHelpMe.Size = new System.Drawing.Size(54, 23);
            this.btnHelpMe.TabIndex = 8;
            this.btnHelpMe.Text = "Help";
            this.btnHelpMe.UseVisualStyleBackColor = true;
            this.btnHelpMe.Click += new System.EventHandler(this.btnHelpMe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "D";
            // 
            // frmQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(754, 366);
            this.Controls.Add(this.btnHelpMe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuestions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.frmQuestions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnAns0;
        private System.Windows.Forms.RadioButton rbtnAns1;
        private System.Windows.Forms.RadioButton rbtnAns2;
        private System.Windows.Forms.RadioButton rbtnAns3;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnHelpMe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}