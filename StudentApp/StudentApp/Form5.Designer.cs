namespace StudentApp
{
    partial class Form5
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
            this.cboStudents = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnRegister = new System.Windows.Forms.Button();
            this.cboCourses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboStudents
            // 
            this.cboStudents.FormattingEnabled = true;
            this.cboStudents.Location = new System.Drawing.Point(128, 28);
            this.cboStudents.Name = "cboStudents";
            this.cboStudents.Size = new System.Drawing.Size(121, 21);
            this.cboStudents.TabIndex = 0;
            this.cboStudents.SelectedIndexChanged += new System.EventHandler(this.cboStudents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course:";
            // 
            // btnUnRegister
            // 
            this.btnUnRegister.Location = new System.Drawing.Point(128, 180);
            this.btnUnRegister.Name = "btnUnRegister";
            this.btnUnRegister.Size = new System.Drawing.Size(121, 23);
            this.btnUnRegister.TabIndex = 4;
            this.btnUnRegister.Text = "Drop Course";
            this.btnUnRegister.UseVisualStyleBackColor = true;
            this.btnUnRegister.Click += new System.EventHandler(this.btnUnRegister_Click);
            // 
            // cboCourses
            // 
            this.cboCourses.FormattingEnabled = true;
            this.cboCourses.Location = new System.Drawing.Point(128, 75);
            this.cboCourses.Name = "cboCourses";
            this.cboCourses.Size = new System.Drawing.Size(121, 21);
            this.cboCourses.TabIndex = 5;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 241);
            this.Controls.Add(this.cboCourses);
            this.Controls.Add(this.btnUnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboStudents);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnRegister;
        private System.Windows.Forms.ComboBox cboCourses;
    }
}