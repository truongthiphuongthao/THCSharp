using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD7_2
{
   public class HoanDoi
    {
        public void HoanVi(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
