using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment02
{
    internal class Point
    {
      
            public int x { get; set; }
            public int y { get; set; }

            public override string ToString()
            {
                return ($"x is {x}, y is {y}");
            }
       
    }
}
