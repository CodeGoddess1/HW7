using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string EnterWord = string.Empty;
            string Exit = string.Empty;
            string EnterWordReversed = string.Empty;
              do
            {
                try
                {
                    Console.Write("Enter text to see if it’s a palindrome    ");
                    EnterWord = Console.ReadLine();
                    Palindrome Paldrm = new Palindrome();
                    EnterWordReversed = Paldrm.GetText(EnterWord);

                    if (Paldrm.IsPalindrome(EnterWord, EnterWordReversed) == true)
                    {
                        Console.WriteLine("Its A Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("Its Not A Palindrome");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("An Error Occurred");
                }
                
              
                 Console.WriteLine(" If you want to Exit type N");
                 Exit = Console.ReadLine();

            } while (Exit!="N");
        }
    }
}
