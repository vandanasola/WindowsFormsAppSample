using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Serializable()]
    internal class Cat
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public void show()
        {
            Console.WriteLine($"name:{Name},description:{Description},age:{Age}");
        }
    }
}
