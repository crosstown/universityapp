using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class CourseRepository
    {
        public List<Course> GetAllCourses()
        {
            List<Course> courseList = new List<Course>();
            try
            {
                string sql = "select * from courses";
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    Course c = new Course();
                    c.CourseNum = (string)dr["CourseNum"];
                    c.CourseName = (string)dr["CourseName"];
                    c.CreditHours = (int)dr["CreditHours"];
                    courseList.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return courseList;
        }
        public List<string> GetCoursesEnrolled(int stuID)
        {
            List<string> courseList = new List<string>();
            try
            {
                string courseNum;
                string sql = "select * from enrollment where StudentID = '"+ stuID.ToString()
                    + "'";
                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                   
                    courseNum = (string)dr["CourseNum"];
                    courseList.Add(courseNum);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return courseList;
        }


        public List<CoursesTakenPreviously> GetCoursesTakenPrevByStudent(int stuID)
        {
            List<CoursesTakenPreviously> ctp = new List<CoursesTakenPreviously>();
            try
            {
                string sql = "select s.StudentID, ct.CourseNum, c.CourseName from Courses c, CoursesTaken ct, Students s where s.StudentID = '" + stuID +
                    "' and c.CourseNum = ct.CourseNum and ct.StudentID = '" + stuID.ToString() + "'";

                DataTable dt = DataAccess.GetDataTable(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    CoursesTakenPreviously courseTaken = new CoursesTakenPreviously();
                    courseTaken.CourseNum = (string)dr["CourseNum"];
                    courseTaken.CourseName = (string)dr["CourseName"];
                    ctp.Add(courseTaken);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return ctp;

        }
        public bool PrerequisiteTaken(int stuID, string cnum)
        {
            bool res = false;
            List<string> courseTaken = new List<string>();
            List<string> preReq = new List<string>();
            string value, value2;
            try
            {
                string sql = "SELECT P.Prereq_Cnum FROM Prerequisites P  WHERE  P.CourseNum = '" + cnum +"'";
                string sql2 = "SELECT CT.CourseNum FROM CoursesTaken CT WHERE CT.StudentID = '"+stuID.ToString()+
                    "' and ct.CourseNum in (SELECT P.Prereq_Cnum FROM Prerequisites P  WHERE  P.CourseNum = '"+cnum +"')";
                DataTable dt = DataAccess.GetDataTable(sql);
                DataTable dt2 = DataAccess.GetDataTable(sql2);
                foreach (DataRow dr in dt.Rows)
                {
                    
                   value  = (string)dr["Prereq_Cnum"];
                    preReq.Add(value);
                }
                foreach (DataRow dr in dt2.Rows)
                {
                    
                    value2 = (string)dr["CourseNum"];
                    courseTaken.Add(value2);
                }

                courseTaken = courseTaken.OrderBy(o => o).ToList();
                preReq = preReq.OrderBy(o => o).ToList();
               

                if (preReq.SequenceEqual(courseTaken))
                {
                    res = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            return res;
        }
       public bool IsThereRoom (string cnum)
        {
            bool res = false;
            string sql = "select Capacity from CoursesOffered where CourseNum = '"+cnum+"'";
            string sql2 = "select NumRegistered from CoursesOffered where CourseNum = '"+cnum+"'";
            int capacity = (int) DataAccess.GetSingleAnswer(sql);
            int numRegistered = (int) DataAccess.GetSingleAnswer(sql2);

            if (numRegistered >= capacity)
                res = false;
            else
                 res = true;
            return res;
        }
        public bool AlreadyRegistered(string cnum, int stuID)
        {
            bool res = false;
            string sql = "select StudentID from Enrollment where CourseNum = '" + cnum +
                "' and StudentID = '" + stuID.ToString() + "'";
            object obj = DataAccess.GetSingleAnswer(sql);
            
            if (obj != null)
                res = true;
            else
                res = false;
            return res;
        }

        public int UpdateCapacityAndNumReg(string cnum, bool registration)
        {
            int res = 0;
           
            string sql = "select NumRegistered from CoursesOffered where CourseNum = '" + cnum+"'";
            int numRegistered = (int)DataAccess.GetSingleAnswer(sql);
            if (registration)
                numRegistered++;
            else
                numRegistered--;
            string sql2 = "UPDATE CoursesOffered SET CourseNum = '"+cnum+
                "', NumRegistered = "+numRegistered+" WHERE CourseNum = '"+cnum+"'; ";
            res = DataAccess.InsUpDel(sql2);
            return res;
        }
    }
}