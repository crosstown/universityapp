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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                StudentBusiness sb = new StudentBusiness();
                List<Student> MList = sb.GetAllStudents();
                cboStudent.DataSource = MList;
                cboStudent.ValueMember = "StudentID";
                cboStudent.DisplayMember = "StudentID";
                cboStudent.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
        private void cmbMajors_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboStudent.SelectedValue != null)
            {
                string cboStu = cboStudent.SelectedValue.ToString();
                int intStuID = int.Parse(cboStudent.SelectedValue.ToString());
                CourseBusiness cb = new CourseBusiness();
                List<CoursesTakenPreviously> cp = cb.GetCourseTakenPrev(intStuID);
            }
        }
        private void cboStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            dg1.DataSource = null;
            dg1.Rows.Clear();
            if (cboStudent.SelectedValue != null)
            {
                string cboStu = cboStudent.SelectedValue.ToString();
                int intStuID;

     
                bool parseOK = Int32.TryParse(cboStudent.SelectedValue.ToString(), out intStuID);
                if (parseOK)
                {   CourseBusiness cb = new CourseBusiness();
                    List<CoursesTakenPreviously> cp = cb.GetCourseTakenPrev(intStuID);
                    dg1.DataSource = cp;
                    dg1.Refresh();
                }
            }
        }
    }
}
