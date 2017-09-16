using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp15
{
    public class Rectangle
    {
        public int length
        {
            get;
            set;
            
            
        }

        public int width
        {
            get;
            set;
            
            
        }

        public int Area()
        {

            return (length * width);        
        }

        public int Primeter()
        {
            return (2 * length + 2 * width);  
        }
    }
}