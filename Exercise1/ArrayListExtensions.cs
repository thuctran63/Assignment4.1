using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    namespace Exercise1
    {
        public static class ArrayListExtensions
        {
            public static int CountInt(this ArrayList al)
            {
                return al.OfType<int>().Count();
            }

            public static int CountOf(this ArrayList al, Type t)
            {
                return al.OfType<object>().Where(x => x.GetType() == t).Count();
            }

            public static int CountOf<T>(this ArrayList al)
            {
                return al.OfType<T>().Count();
            }

            public static T MaxOf<T>(this ArrayList array) where T : IComparable
            {
                if (typeof(T) == typeof(int) || typeof(T) == typeof(double) ||
                    typeof(T) == typeof(float) || typeof(T) == typeof(decimal) ||
                    typeof(T) == typeof(long) || typeof(T) == typeof(short) ||
                    typeof(T) == typeof(byte) || typeof(T) == typeof(uint) ||
                    typeof(T) == typeof(ulong) || typeof(T) == typeof(ushort) ||
                    typeof(T) == typeof(sbyte))
                {
                    return array.OfType<T>().Max();
                }
                else
                {
                    throw new InvalidOperationException("T must be a numeric data type.");
                }
            }
        }
    }
}
