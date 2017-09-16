using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp15
{
    public class Square
    {
        public int LengthA
        {
            get;
            set;


        }

        public int Primeter()
        {

            return (LengthA * 4);
        }

        public int Area()
        {
            return (LengthA * LengthA);
        }
    }
}