using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Entertainment
    {
        string type;
        string favActor;
        public Entertainment() { }
        public Entertainment(string type, string favActor)
        {
            this.type = type;
            this.favActor = favActor;
        }
        public string Type { get { return type; } }
        public string FavActor { get { return favActor; } }

    }
}
