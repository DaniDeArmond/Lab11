using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Staff : Person
    {
        #region Properties
        private string school;
        private double pay;

        public string School
        {
            set
            {
                school = value;
            }
            get
            {
                return school;
            }
        }
        public double Pay
        {
            set
            {
                pay = value;
            }
            get
            {
                return pay;
            }
        }

        #endregion

        #region Methods
        private Staff() { }

        public Staff(string YourName, string YourAddress, string YourSchool, double YourPay) : base(YourName, YourAddress)
        {
            School = YourSchool;
            Pay = YourPay;
        }
        public override string ToString()
        {
            return base.ToString() + ($", {School}, {Pay}");
        }

        #endregion
    }
}
