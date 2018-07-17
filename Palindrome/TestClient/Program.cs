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
                // converting string to array
                char[] arr = myStr.ToCharArray();
                
                // Reversing string
                Array.Reverse(arr);

                //removing spacing from reversed string
                //myStr = ("", arr);

                //changing to lowercase
                myStr = myStr.ToLower();

                Console.WriteLine(myStr);

                string backwards = new string(arr);
                
                return myStr == backwards;
            }
    }   
}
