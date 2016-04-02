using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class CoursesOffered
    {
        private string courseNum;
        private int numRegistered;
        private int capacity;

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

        public int NumRegistered
        {
            get
            {
                return numRegistered;
            }

            set
            {
                numRegistered = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }
    }
}
