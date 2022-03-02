using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student :Istudent
    {
        public static int no_of_students;
        string name;
        int count;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Count =>count;
        public Student()=>count=++no_of_students;

    }
}
