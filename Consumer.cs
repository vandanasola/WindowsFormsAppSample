using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Consumer
    {
        string name;
        int consumerId;
        int units;
        double bill;
        string branch;
        public Consumer(string name,int consumerId,int units,double bill,string branch)
        {
            this.name = name;
            this.consumerId = consumerId;
            this.units = units; 
            this.bill = bill;
            this.branch = branch;
        }
        public string Name
        {
            get;
        }
        int ConsumerId { get; }
        int Units { get; }
        double Bill { get; }
        string Branch { get; }

        
    }
}
