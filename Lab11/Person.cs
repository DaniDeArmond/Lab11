using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Person
    {
        #region Properties

        private string name, address;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }
        #endregion

        #region Methods

        protected internal Person() { }

        public Person(string YourName, string YourAddress)
        {
            Name = YourName;
            Address = YourAddress;
        }
        override public string ToString()
        {
            string MyString = ($"{Name}, {Address}");
            return MyString;
        }

        #endregion

    }
}
