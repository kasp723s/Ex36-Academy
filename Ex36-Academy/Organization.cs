using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Academy
{
    public class Organization
    {
        private readonly string _name;
        public string Name
        {
            get { return _name; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Organization(string name, string address)
        {
            _name = name;
            this.address = address;
        }
    }
}
