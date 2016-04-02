namespace StudentApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewCoursesTakenByStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewEnrollmentForCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActionsRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewUnregister = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuView,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(92, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewCoursesTakenByStudent,
            this.mnuViewEnrollmentForCourse});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "View";
            // 
            // mnuViewCoursesTakenByStudent
            // 
            this.mnuViewCoursesTakenByStudent.Name = "mnuViewCoursesTakenByStudent";
            this.mnuViewCoursesTakenByStudent.Size = new System.Drawing.Size(211, 22);
            this.mnuViewCoursesTakenByStudent.Text = "Courses Taken by Student";
            this.mnuViewCoursesTakenByStudent.Click += new System.EventHandler(this.mnuViewCoursesTakenByStudent_Click);
            // 
            // mnuViewEnrollmentForCourse
            // 
            this.mnuViewEnrollmentForCourse.Name = "mnuViewEnrollmentForCourse";
            this.mnuViewEnrollmentForCourse.Size = new System.Drawing.Size(211, 22);
            this.mnuViewEnrollmentForCourse.Text = "Enrollment for course";
            this.mnuViewEnrollmentForCourse.Click += new System.EventHandler(this.mnuViewEnrollmentForCourse_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuActionsRegister,
            this.mnuViewUnregister});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // mnuActionsRegister
            // 
            this.mnuActionsRegister.Name = "mnuActionsRegister";
            this.mnuActionsRegister.Size = new System.Drawing.Size(152, 22);
            this.mnuActionsRegister.Text = "Register";
            this.mnuActionsRegister.Click += new System.EventHandler(this.mnuActionsRegister_Click);
            // 
            // mnuViewUnregister
            // 
            this.mnuViewUnregister.Name = "mnuViewUnregister";
            this.mnuViewUnregister.Size = new System.Drawing.Size(152, 22);
            this.mnuViewUnregister.Text = "Unregister";
            this.mnuViewUnregister.Click += new System.EventHandler(this.mnuViewUnregister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Student Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuViewCoursesTakenByStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuViewEnrollmentForCourse;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuActionsRegister;
        private System.Windows.Forms.ToolStripMenuItem mnuViewUnregister;
    }
}

