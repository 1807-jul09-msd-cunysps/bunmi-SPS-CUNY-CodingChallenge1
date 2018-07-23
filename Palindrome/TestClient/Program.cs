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

            string  s = myStr.Replace(" ", "");
            s = s.ToLower();
            char[] arr = s.ToCharArray();

            Array.Reverse(arr);
            String strRev = new String(arr);
            {
                if (s == strRev)
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
