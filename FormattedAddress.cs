using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FormattedAddress : IEnumerable<string>
    {

        private List<string> internalList = new List<string>();
        public IEnumerator<string> GetEnumerator() => internalList.GetEnumerator();

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => internalList.GetEnumerator();

        public void Add(string firstname, string lastname, string street, string city, string state, string zipcode) => internalList.Add(
            $@"{firstname} {lastname} 
{street} 
{city}, {state} 
{zipcode}");



    }
}
