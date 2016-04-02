using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int resulIns;
            CourseBusiness cb = new CourseBusiness();
            int stuID = Int32.Parse(txtStudentID.Text.ToString());
            string cboCo = cboCourse.SelectedValue.ToString();
            
            resulIns = cb.RegisterStudent(stuID, cboCo);
            MessageBox.Show("Student Registered");
        
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                CourseBusiness cb = new CourseBusiness();
                List<Course> CList = cb.GetAllCourses();
                cboCourse.DataSource = CList;
                cboCourse.ValueMember = "CourseNum";
                cboCourse.DisplayMember = "CourseNum";
                cboCourse.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
