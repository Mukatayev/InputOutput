using System;
using System.Collections;

namespace InputOutput
{
    class Program
    { 
            static void Main(string[] args)
            {
                bool showMenu = true;
                while (showMenu)
                {
                    showMenu = MainMenu();
                }
            }
            private static bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Simple app for working with String");
                Console.WriteLine("1) Reverse String");
                Console.WriteLine("2) to make UPPER");
                Console.WriteLine("3) to make lower");
                Console.WriteLine("4) Exit press q ");
                Console.Write("\r\n What would u like to prefer?");

                switch (Console.ReadLine())
                {
                    case "1":
                        ReverseString();
                        return true;
                    case "2":
                        ToUppercase();
                        return true;
                     case "3":
                        ToLowerCase();
                        return true;
                     case "q":
                        return false;
                    default:
                        return true;
                }
            }

            private static string FirstLine()
            {
                Console.Write("Enter the string: ");
                return Console.ReadLine();
            }

            private static void ReverseString()
            {
                Console.Clear();
                Console.WriteLine("Reverse String");
                char[] charArray = FirstLine().ToCharArray();
                Array.Reverse(charArray);
                ShowResult(new String(charArray));
            }

            private static void ToLowerCase()
            {
                 Console.Clear();
                 Console.WriteLine("Lower String");
                 string result = FirstLine().ToLower();
                 ShowResult(result);
            }

            private static void ToUppercase()
            {
                Console.Clear();
                Console.WriteLine("Upper String");
                string result = FirstLine().ToUpper();
                ShowResult(result);
        }




        private static void ShowResult(string message)
            {
                Console.WriteLine($"\r\nResult: {message}");
                Console.Write("\r\n Press enter to return to menu");
                Console.ReadLine();
            }
        }
    }