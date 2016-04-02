using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class PreRequisite
    {
        private string courseNum;
        private string preReq_Cnum;
        private int cnum;

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

        public string PreReq_Cnum
        {
            get
            {
                return preReq_Cnum;
            }

            set
            {
                preReq_Cnum = value;
            }
        }

        public int Cnum
        {
            get
            {
                return cnum;
            }

            set
            {
                cnum = value;
            }
        }
    }
}
