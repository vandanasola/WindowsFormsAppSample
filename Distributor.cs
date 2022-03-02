using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Distributor :Customer
    {
        string area;
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public Distributor() { }
        public Distributor(int id,string name,string mail,string phone,string area):base(id,name,mail,phone)
        {
            this.Area = area;
        }

    }
}
