using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = string.Empty;

            str = "A nut for a jar of tuna";
            Console.WriteLine("Is {0} palindrome? {1}", str, palindromeTest(str));

            str = "borrow or rob";
            Console.WriteLine("Is {0} palindrome? {1}", str, palindromeTest(str));

            str = "343";
            Console.WriteLine("Is {0} palindrome? {1}", str, palindromeTest(str));

            Console.ReadLine();

        }
        public static bool palindromeTest(string str)
        {
            string myStr = str.ToString();
            myStr.Replace(" ", "");
            myStr.ToLower();

            string myTest = str.ToString();
            myTest.Replace(" ", "");
            myTest.ToLower();

            if (myTest == myStr)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
