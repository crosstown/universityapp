using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    public class Enrollment
    {
        private string courseNum;
        private int studentID;
        private int sectionNum;
        private int cNum;

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

        public int StudentID
        {
            get
            {
                return studentID;
            }

            set
            {
                studentID = value;
            }
        }

        public int SectionNum
        {
            get
            {
                return sectionNum;
            }

            set
            {
                sectionNum = value;
            }
        }

        public int CNum
        {
            get
            {
                return cNum;
            }

            set
            {
                cNum = value;
            }
        }
    }
}
