/*
 * C# Program to Create Generic Delegate
 */

using System;
using System.Collections.Generic;
delegate T NumberChanger<T>(T n);
namespace generic_delegate
{
    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

    }
}
