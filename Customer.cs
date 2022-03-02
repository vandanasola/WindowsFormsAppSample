using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Customer
    {
        int customerid;
        string name;
        string email;
        string phone;
        /* public string city;
         public string state;
         public string zipCode;
         public string country;*/
        public Customer()
        {
        }
        public Customer(int id, string name, string email, string phone)
        {
            customerid = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }
        public int Customerid
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;

        }
        public string Email
        {
            get;
            set;
        }
        public string Phone
        {
            get;
            set;

        }

       /* public int Customerid
        {
            get { return customerid; }
        }
        public string Name { get { return name; } }
        public string Email { get { return email; } }
        public string Phone { get { return phone; } }
       */

    }
}
