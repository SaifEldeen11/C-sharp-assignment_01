using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_Saif
{
    internal class point
    {
        public int x;
        public int y;

        public override string ToString()
        {
            //return base.ToString();
            return $" ({x}) ,({y}) "; 
        }
        public override bool Equals(object obj)
        {
            //return base.Equals(obj);
            return x==((point)obj).x && y==((point)obj).y ;
        }

    }


    internal class points3D : point
    {
        public int z;
    }

    struct temp 
    {
           
    }

}
