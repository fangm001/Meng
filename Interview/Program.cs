using System;
using System.Collections;
using System.Collections.Generic;


namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            //testInterview();
            TestRecursion();
            Console.Read();
        }

        static void TestRecursion()
        {
            Console.WriteLine(Recursion.GetFibonacci(10));
        }
            static void BubbleSortTest() {
            CArray nums = new CArray(10);
            Random rnd = new Random(100);
            for (int i = 0; i < 10; i++)
                nums.Insert((int)(rnd.NextDouble() * 100));
            Console.WriteLine("Before sorting: ");
            nums.DisplayElements();
            Console.WriteLine("\nDuring sorting: ");
            nums.BubbleSort();
            Console.WriteLine("\nAfter sorting: ");
            nums.DisplayElements();
            Console.Read();
        }
        

        static void SelectionSortTest()
        {
            CArray nums = new CArray(10);
            Random rnd = new Random(100);
            for (int i = 0; i < 10; i++)
                nums.Insert((int)(rnd.NextDouble() * 100));
            Console.WriteLine("Before sorting: ");
            nums.DisplayElements();
            Console.WriteLine("\nDuring sorting: ");
            nums.SelectionSort();
            Console.WriteLine("\nAfter sorting: ");
            nums.DisplayElements();
            Console.Read();
        }

        static void ArrayListTest() {
            List<object> myAL = new List<object>();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("    Count:    {0}", myAL.Count);
            Console.WriteLine("    Capacity: {0}", myAL.Capacity);
            Console.Write("    Values:");
            Console.Read();
        }

        static void chapterOne() {
            int[] nums = new int[100000];
            BuildArray(nums);
            Timing tobj = new Timing();
            tobj.startTime();
            DisplayNums(nums);
            tobj.StopTime();
            Console.WriteLine("time (.NET): " + tobj.Result().TotalSeconds.ToString());
            Console.Read();
        }

        static void testInterview() {
            Console.WriteLine("Hello World!");
            List<string> test = new List<string> { "abc", "cba", "eee", "fff" };
            List<string> test2 = new List<string> { "abc", "cba", "eee", "fff", "" };
            List<string> test3 = new List<string> { "abc", "cba", "afds", "sdfa", "" };
            List<string> test4 = new List<string> { "abc", "cba" };
            List<string> test5 = new List<string> { "" };
            List<string> test6 = new List<string> { };
            Console.WriteLine(GetUnique(test));
            Console.WriteLine(GetUnique(test2));
            Console.WriteLine(GetUnique(test3));
            Console.WriteLine(GetUnique(test4));
            Console.WriteLine(GetUnique(test5));
            Console.WriteLine(GetUnique(test6));
            Console.Read();
        }
        static void BuildArray(int[] arr) {
            for (int i = 0; i <= 9999; i++)
                arr[i] = i;
        }

        static void DisplayNums(int[] arr) {
            for (int i = 0; i <= 9999; i++)
                Console.Write(arr[i] + " ");
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int GetUnique(List<string> input) {
            if (input.Count == 0) {
                return 0;
            }
            int result = 1;
            List<string> copy = new List<string>(input);
            if (copy.Count > 1)
            {
                for (int i = 1; i < copy.Count; i++)
                {
                    if (copy[0] == copy[i] || Reverse(copy[0]) == copy[i]) {
                        copy.Remove(copy[i]);
                        
                    }
                }
                copy.Remove(copy[0]);
                return result + GetUnique(copy);
            }
            else {
                return 1;
            }
        }
    }
}