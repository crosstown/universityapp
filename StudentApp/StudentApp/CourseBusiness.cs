using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class CourseBusiness
    {
        CourseRepository _crep = new CourseRepository();
        StudentRepository _srep = new StudentRepository();


        public List<Course> GetAllCourses()
        {
            return _crep.GetAllCourses();
        }

        public List<string> GetCoursesEnrolled(int stuID)
        {
            return _crep.GetCoursesEnrolled(stuID);
        }

        public List<CoursesTakenPreviously> GetCourseTakenPrev(int stuID)
        {
            return _crep.GetCoursesTakenPrevByStudent(stuID);        }

        public int RegisterStudent (int stuID, string cnum)
        {
            bool registration = true;
            int resultEnrolment = 0;
            int resultUpdate = 0;
            bool res = false;
            if (_srep.DoesStudentExist(stuID))
            {
                if (_crep.PrerequisiteTaken(stuID, cnum))
                {
                    if (_crep.IsThereRoom(cnum))
                    {
                        if (_crep.AlreadyRegistered(cnum, stuID) == false)
                        {
                            //Register student
                             resultEnrolment = _srep.InsertEnrollment(cnum, stuID);

                            //update courseoffered capacity and numreg
                            
                            resultUpdate = _crep.UpdateCapacityAndNumReg(cnum, registration);
                            res = true;    
                        }
                        else
                        {

                        }
                    }
                }
            }
            
           

            return resultUpdate;
        }

        public int UnregisterStudent(int stuID, string cnum)
        {
            int resultUpdate;
            bool registration = false;
            
            int result =_srep.DeleteEnrollment(cnum, stuID);

            //update courseoffered capacity and numreg
            resultUpdate = _crep.UpdateCapacityAndNumReg(cnum, registration);

            return result;

        }

    }
}
