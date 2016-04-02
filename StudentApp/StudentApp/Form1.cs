using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuViewCoursesTakenByStudent_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
        private void mnuViewEnrollmentForCourse_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
        private void mnuActionsRegister_Click(object sender, EventArgs e)
        {
            Form4 f4= new Form4();
            f4.Show();
        }

        private void mnuViewUnregister_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
    }

