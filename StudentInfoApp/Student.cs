using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApp
{
    class Student
    {
        public string regNo;
        public string firstName;
        public string lastName;
        


        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public string GetCodeNo(string code)
        {
            return regNo + code;
        }

    }
}
