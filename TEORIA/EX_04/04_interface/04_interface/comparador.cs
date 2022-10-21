using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _04_interface
{
    class comparador : IComparer<ejemplo>
    {
        public int Compare([AllowNull] ejemplo x, [AllowNull] ejemplo y)
        {
            if (x.N1 > y.N1)
            {
                return 1;
            }
            else
            {
                if (x.N1 == y.N1)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
