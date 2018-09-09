using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHW7T
{
    class Square : Shape
    {
        int side;
        public Square(string name, int side) : base(name)
        {

        }
        public override int Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
