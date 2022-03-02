using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Serializable()]
    internal class Employee
    {

        int empid;
        string name;
        DateTime joindate;
        string department;
        double salary;
        public int EmpId { get; set; }
        public string Name { get; set; }
        public DateTime Joindate { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }




    }
}
