using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Indexer<T>
    {
        private T[] array = new T[100];
        public T this[int i]
        {
            get{ return array[i];}
            set { array[i] = value; }
        }
    }
}
