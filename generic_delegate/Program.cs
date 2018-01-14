﻿/*
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

        public static int GetNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);
            nc1(25);
            Console.WriteLine("Value of Num: {0}", GetNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", GetNum());
            Console.ReadKey();
        }
    }
}
