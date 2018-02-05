using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Student : Person
    {
        #region Properties
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            set
            {
                program = value;
            }
            get
            {
                return program;
            }
        }
        public int Year
        {
            set
            {
                year = value;
            }
            get
            {
                return year;
            }
        }
        public double Fee
        {
            set
            {
                fee = value;
            }
            get
            {
                return fee;
            }
        }

        #endregion
        #region Methods
        private Student() { }
        public Student(string YourName, string YourAddress, string YourProgram, int YourYear, double YourFee) : base(YourName, YourAddress)
        {
            Program = YourProgram;
            Year = YourYear;
            Fee = YourFee;
        }
        public override string ToString()
        {
            return base.ToString() + ($", {Program}, {Year}, {Fee}");
        }


        #endregion

    }
}
