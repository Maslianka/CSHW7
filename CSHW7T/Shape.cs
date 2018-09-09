using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHW7T
{
    abstract class Shape
    {
        Shape(string _name)
        {
            name = _name;
        }
        string name;
        string Name { get; set; }
        abstract public int Area();
        abstract public int Perimeter(); 
    }
}
