using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationApp
{
    class Student
    {
        public string reg;
        public string first_name;
        public string last_name;

        public string GetFullName()
        {
            return first_name +" "+ last_name;

        }
    }
}
