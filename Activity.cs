using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Activity:Bank,Iwalk,IFly
    {
        public override double ROI()
        {
            //throw new NotImplementedException();
            return 7.2;
        }
        public void Makeit()
        {
            Console.WriteLine("This is a method of IFly interface");
        }
        public void Doit()
        {
            Console.WriteLine("This is a method of Iwalk interface");
        }
    }
}
