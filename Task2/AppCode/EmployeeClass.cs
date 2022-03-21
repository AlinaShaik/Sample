using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task2.AppCode
{
    public class EmployeeClass : Employee
    {
        public int Id
        {
            get
            {
                return 1;
            }
            set
            {
                Id = value;
            }
        }
        public string Name
        {
            get
            {

                return "Seema";

            }
            set
            {
                Name = value;
            }
        }
        public string JOb
        {
            get
            {
                return "tester";

            }
            set
            {

                JOb = value;
            }
        }


     static void Main()
        {

        }

    }
}