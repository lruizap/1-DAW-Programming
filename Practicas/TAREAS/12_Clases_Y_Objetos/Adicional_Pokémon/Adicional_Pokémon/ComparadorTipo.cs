using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Adicional_Pokémon
{
    class ComparadorTipo : IComparer<Pokemon>
    {
        public int Compare([AllowNull] Pokemon x, [AllowNull] Pokemon y)
        {
            if (x.Type1 > y.Type1)
            {
                return 1;
            }
            else
            {
                if (x.Type1 == y.Type1)
                {
                    if (x.Type2 > y.Type2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (x.Type2 == y.Type2)
                        {
                            return 0;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
