using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Course
    {
        private string courseNum;
        private string courseName;
        private int creditHours;

        public string CourseNum
        {
            get
            {
                return courseNum;
            }

            set
            {
                courseNum = value;
            }
        }

        public string CourseName
        {
            get
            {
                return courseName;
            }

            set
            {
                courseName = value;
            }
        }

        public int CreditHours
        {
            get
            {
                return creditHours;
            }

            set
            {
                creditHours = value;
            }
        }
    }
}
