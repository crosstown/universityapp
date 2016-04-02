using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class StudentRepository
    {
        public List<Student> GetAllStudents()
        {
            List<Student> STList = new List<Student>();
            try
            {
                string sql = "select * from Students";
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    Student st = new Student();
                    st.StudentID = (int)dr["StudentId"];
                    st.FirstName = (string)dr["FirstName"];
                    st.LastName = (string)dr["LastName"];
                    st.Major = (string)dr["Major"];
                    st.Address = (string)dr["Address"];
                    //     st.City = (string)dr["City"];
                    //     st.State = (string)dr["State"];
                    STList.Add(st);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return STList;
        }

        public List<Student> GetStudentsEnrolled(string courseNum)
        {
            List<Student> studentEnrolled = new List<Student>();
            try
            {
                string sql = "select s.StudentID, s.LastName, s.FirstName from Students s," +
                    "Enrollment e, Courses c where e.CourseNum = '" +
                    courseNum.ToString() + "' and c.CourseNum ='" + courseNum.ToString() +
                    "' and s.StudentID = e.StudentID";

                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    Student stu = new Student();
                    stu.StudentID = (int)dr["StudentID"];
                    stu.LastName = (string)dr["LastName"];
                    stu.FirstName = (string)dr["FirstName"];
                    //           stu.Address = (string)dr["Address"];
                    //           stu.Major = (string)dr["Major"];

                    studentEnrolled.Add(stu);


                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return studentEnrolled;

        }

        public List<int> GetStudentEnrolledIDonly()
        {
            List<int> studentList = new List<int>();
            try
            {
                int studentID;
                string sql = "select * from enrollment";
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {

                    studentID = (int)dr["StudentID"];
                    studentList.Add(studentID);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return studentList;
        }
        public bool DoesStudentExist(int studentID)
        {
            bool res = false;
            try
            {
                string sql = "select count (StudentID) from students where StudentID = '"
                    + studentID.ToString() + "'";
                int resultBack = (int)DataAccess.GetSingleAnswer(sql);
                if (resultBack > 0)
                    res = true;
            }
            catch (Exception ex)
            {
                throw;
            }
            return res;
        }

        public int InsertEnrollment(string cnum, int stuID)
        {
            int res = 0;
            string sql = "INSERT INTO Enrollment VALUES ('" + cnum + "', "+ stuID +" , 1, 100);";
            res = DataAccess.InsUpDel(sql);
            return res;
        }

        public int DeleteEnrollment(string cnum, int stuID)
        {
            int res = 0;
                       
            string sql2 = "DELETE FROM Enrollment WHERE CourseNum = '"+cnum+"' and StudentID = '"+stuID+"'";
            res = DataAccess.InsUpDel(sql2);
            
            return res;
        }



        /*     public List<Major> GetAllMajors()
             {
                 List<Major> MList = new List<Major>();
                 try
                 {
                     string sql = "select * from Majors";
                     DataTable dt = DataAccess.GetDataTable(sql);
                     foreach (DataRow dr in dt.Rows)
                     {
                         Major mj = new Major();
                         mj.MajorId = (int)dr["MajorId"];
                         mj.Maj = (string)dr["Major"];
                         MList.Add(mj);
                     }
                 }
                 catch (Exception)
                 {
                     throw;
                 }
                 return MList;
             } */
    }
}
