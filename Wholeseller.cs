using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Wholeseller :Customer
    {
        public string nicheBusiness;
        public Wholeseller() { }
        public Wholeseller(int id,string name,string mail,string phone,string niche):base(id,name,mail,phone)
        {
            nicheBusiness = niche;
        }
    }
}
