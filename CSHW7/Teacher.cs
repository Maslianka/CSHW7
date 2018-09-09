using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHW7
{
    class Teacher : Staff
    {
        public override string Name => base.Name;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Print()
        {
            base.Print();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
