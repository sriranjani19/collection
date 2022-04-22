

   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Person
    {
        public string PhoneNo;
        public string Name;
        public string Address;
        public string City;
        public string State;
        public string Zip;
        public string EmailId;

        public Person(string phoneNo, string name, string address, string city, string state, string zip, string emailid)
        {
            this.PhoneNo = phoneNo;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.EmailId = emailid;
        }
    }
}