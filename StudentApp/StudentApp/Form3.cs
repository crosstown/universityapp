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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                CourseBusiness cb = new CourseBusiness();
                List<Course> CList = cb.GetAllCourses();
                cboCourses.DataSource = CList;
                cboCourses.ValueMember = "CourseNum";
                cboCourses.DisplayMember = "CourseNum";
                cboCourses.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cboCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            dg2.DataSource = null;
            dg2.Rows.Clear();
            if (cboCourses.SelectedValue != null)
            {
                string cboCo = cboCourses.SelectedValue.ToString();
                int intCourseNum;

                lblTest.Text = "No";
                bool parseOK = Int32.TryParse(cboCourses.SelectedValue.ToString(), out intCourseNum);
               
               
                    lblTest.Text = "Yes";
                    StudentBusiness sb = new StudentBusiness();
                    List<Student> studenList = sb.GetEnrollment(cboCo);
                    dg2.DataSource = studenList;
                    dg2.Refresh();               
            }
        }
    }
}
