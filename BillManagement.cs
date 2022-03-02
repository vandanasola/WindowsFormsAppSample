using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class BillManagement

    {

        public string name;
        public int consumerId;
        public int units;
        public int bill;
        public string branch;


        public BillManagement(int n)
    {
        List<Consumer> cons = new List<Consumer>();
           for(int i=0;i<n;i++)
            {
                this.name = Console.ReadLine();
                this.consumerId=int.Parse(Console.ReadLine());
                this.units = int.Parse(Console.ReadLine());
                this.bill= int.Parse(Console.ReadLine());
                this.branch=Console.ReadLine();
                cons.Add(new Consumer(name, consumerId, units, bill, branch));
               

            }
           foreach(Consumer cs in cons)
            {

            }
            
         
        
    }

        public Consumer Cons { get; }

    
        
        public static void Findcons(int bill)
        {
            
            
        }
    }
}
