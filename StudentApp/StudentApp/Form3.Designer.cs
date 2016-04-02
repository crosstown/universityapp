namespace StudentApp
{
    partial class Form3
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
            this.cboCourses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg2 = new System.Windows.Forms.DataGridView();
            this.lblTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCourses
            // 
            this.cboCourses.FormattingEnabled = true;
            this.cboCourses.Location = new System.Drawing.Point(116, 36);
            this.cboCourses.Name = "cboCourses";
            this.cboCourses.Size = new System.Drawing.Size(121, 21);
            this.cboCourses.TabIndex = 0;
            this.cboCourses.SelectedIndexChanged += new System.EventHandler(this.cboCourses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Number";
            // 
            // dg2
            // 
            this.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg2.Location = new System.Drawing.Point(309, 36);
            this.dg2.Name = "dg2";
            this.dg2.Size = new System.Drawing.Size(326, 150);
            this.dg2.TabIndex = 2;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(47, 141);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 13);
            this.lblTest.TabIndex = 3;
            this.lblTest.Text = "label2";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 280);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCourses);
            this.Name = "Form3";
            this.Text = "View Enrollment";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg2;
        private System.Windows.Forms.Label lblTest;
    }
}