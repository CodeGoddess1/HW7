using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        public string GetText(string msg)
        {
            try
            {
                string textInfo = string.Empty;
                char[] chArray = msg.ToCharArray();
                char[] PalChar = new char[chArray.Length];
                PalChar = chArray;
                textInfo = msg;

                Array.Reverse(PalChar, 0, PalChar.Length);
                return new string(PalChar);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occurred");
                return null;
            }
           
            
        }
        public bool IsPalindrome(string userInput, string userInputReversed)
        {
            try
            {
                if (userInput == userInputReversed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("An Error Occurred");
                return false;
            }
            
        }







    }
}
