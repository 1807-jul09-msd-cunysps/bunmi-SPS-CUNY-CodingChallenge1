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
            Console.WriteLine("Is Palindrome {0} {1}", myStr, IsPalindrome(myStr));

            myStr = "borrow or rob";
            Console.WriteLine("Is Palindrome {0} {1}", myStr, IsPalindrome(myStr));

            myStr = "343";
            Console.WriteLine("Is Palindrome {0} {1}", myStr, IsPalindrome(myStr));

            Console.ReadLine();

        }
            public static bool IsPalindrome(string myStr)
            {
                char[] arr = myStr.ToCharArray();
                Array.Reverse(arr);
                
                string backwards = new string(arr);
                
            return myStr == backwards;
            }
    }   
}
