using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.NUnit
{
    class LeapClass
    {
        int year;
        public LeapClass(int year)
        {
            this.year = year;
        }
        public bool IsLeap()
        {
            if((year % 400 == 0 && year % 4 == 0) || year % 100 != 0)
            {
                return true;
            }
            else return false;
        }
    }
}
