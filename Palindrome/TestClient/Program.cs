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
            string myStr = string.Empty;

            myStr = "A nut for a jar of tuna";
            Console.WriteLine("Is {0} palindrome? {1}", myStr, IsPalindrome(myStr));

            myStr = "borrow or rob";
            Console.WriteLine("Is {0} palindrome? {1}", myStr, IsPalindrome(myStr));

            myStr = "343";
            Console.WriteLine("Is {0} palindrome? {1}", myStr, IsPalindrome(myStr));

            Console.ReadLine();

        }
        public static bool IsPalindrome(string myStr)
        {

            myStr = myStr.Replace(" ", "");
            myStr = myStr.ToLower();
            char[] arr = myStr.ToCharArray();

            Array.Reverse(arr);
            String strRev = new String(arr);
            strRev = strRev.Replace(" ", "");
            strRev = strRev.ToLower();
            //Console.WriteLine(myStr);
            // Console.WriteLine(strRev);
            // Console.ReadLine();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (myStr == strRev)
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
}
