using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Movie :Entertainment
    {
        string moviename;
        string director;
        string producer;
        public Movie() { }
        public Movie(string type,string favActor,string moviename,string director,string producer):
            base(type,favActor)
        {
            this.moviename = moviename; 
            this.director = director;
            this.producer = producer;
        }
        public string MovieName
        {
            get { return moviename; }
        }
        public string Director
        {
            get { return director; }
        }
        public string Producer
        {
            get { return producer; }
        }



    }
}
