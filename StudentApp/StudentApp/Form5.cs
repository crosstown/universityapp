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
    public partial class Form5 : Form
    {
        List<string> CList;
        List<int> noDupSList;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                CourseBusiness cb = new CourseBusiness();
                StudentBusiness sb = new StudentBusiness();
                
                List<int>SList = sb.GetStudentEnrolledIDs();
                noDupSList = SList.Distinct().ToList();
                cboStudents.DataSource = noDupSList;
               
                cboStudents.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseBusiness cb = new CourseBusiness();
            int stuID = int.Parse(cboStudents.SelectedItem.ToString());

            CList = cb.GetCoursesEnrolled(stuID);
            cboCourses.DataSource = CList;
            
            cboCourses.Refresh();
        }

        private void btnUnRegister_Click(object sender, EventArgs e)
        {

            int stuID = int.Parse(cboStudents.SelectedValue.ToString());
            string cnum = cboCourses.SelectedValue.ToString();

            CourseBusiness cb = new CourseBusiness();
            int res = cb.UnregisterStudent(stuID, cnum);
            MessageBox.Show("Student " + stuID.ToString() +" Unregistered for "+cnum);
            
                       
            CList.Remove(cnum);
            cboCourses.DataSource = null;
            cboCourses.Items.Clear();
            cboCourses.DataSource = CList;
            cboCourses.Refresh();
        }
    }
    }

