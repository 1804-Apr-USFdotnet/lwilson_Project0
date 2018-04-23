using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{

    //case insensitive palindrome
    class Palindromes
    {
        string strOne;
        string strTwo;

        public Palindromes(string one, string two)
        {
            strOne = one;
            strTwo = two;
        }

        bool CheckLengths()
        {
            if (strOne.Length == strTwo.Length)
            {
                Console.WriteLine("lengths are same");
                return true;
               
            }
            else
            {
                Console.WriteLine("lengths are not same");
                return false;
            }
        }

        bool checkChars()
        {

            bool isPalin = true;



            for (int i = 0; i != strOne.Length; i++)
            {
                char c1 = strOne[i];

                for (int j = strTwo.Length - 1; j != 0; j--)
                {

                    
                    char c2 = strTwo[j];

                    Console.WriteLine(c1 + " and " + c2);

                    if (c1 != c2)
                    {
                        isPalin = false;
                    }


                }
            }

            return isPalin;
        }



        /*
         * if lengths are the same
         * strip strings of punctuation
         * and compare each character
         * */

        public bool IsPalindrome()
        {
            if (CheckLengths() == false)
            {
                Console.WriteLine(strOne + " and " + strTwo + " are not palindromes.");
                return false;
            }
            else
            {
                //stripPunctuation

                if (checkChars() == false)
                {
                    
                    Console.WriteLine(strOne + " and " + strTwo + " are not palindromes.");
                    return false;
                }
                else
                {
                    Console.WriteLine(strOne + " and " + strTwo + " are palindromes.");
                    return true;
                }


            }
        }
    }
}
    
