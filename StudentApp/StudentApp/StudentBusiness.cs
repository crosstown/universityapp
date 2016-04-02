using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class StudentBusiness
    {
        StudentRepository _srep = new StudentRepository();

        public List<Student> GetAllStudents()
        {
            return _srep.GetAllStudents();
        }

        StudentRepository _srepo = new StudentRepository();

        public List<Student> GetEnrollment(string courseNumber)
        {
            return _srepo.GetStudentsEnrolled(courseNumber);
        }
        public bool DoesStudentExist(int stuID)
        {
            bool result;
            StudentRepository sr = new StudentRepository();
            result = sr.DoesStudentExist(stuID);
            return result;
        }
        public List<int> GetStudentEnrolledIDs()
        {
            return _srep.GetStudentEnrolledIDonly();
        }

    }
}
