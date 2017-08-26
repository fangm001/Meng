using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    public class Recursion
    {
       public static int GetFibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
               // Console.Write("{0} ", n);
                return n;
            }
            else {
                var result = GetFibonacci(n - 1) + GetFibonacci(n - 2);
                //Console.Write("{0} ", result);
                return result;
            }
        }

        public static string GetStringPattern(int n) {
            // 1, 11, 21, 1211, 111221, 312211,13112221

            string first = "1";
            //string result = "1";
            if (n == 1)
                return first;
            for (int i = 0; i < n; i++) {

            }

            return "";
        }
    }
}
