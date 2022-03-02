using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class LiveShows: Entertainment
    {
        string showname;
        string host;
        public LiveShows() { }
        public LiveShows(string type,string favActor,string showname,string host):base(type,favActor)
        {
            this.showname = showname;
            this.host = host;
        }
        public string Host
        {
            get { return host; }
        }
        public string ShowName
        {
            get { return showname; }
        }

    }
}
