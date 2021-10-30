using System;
using HomeWork1Library;
using ClassLibraryHomework12;
using ClassLibraryHomework13;

namespace Homework1
{  
    class Program
    {
        static Action action;

        static void Main(string[] args)
        {
            int a = 1;

            while (a != 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Menu\n " +
                "- Read the data from the file - press to 1\n - Calculate the square root - press to 2\n - Get html code ya.ru - press to 3\n" +
                " - Finish the job - press to 4\n");

                int s = int.Parse(Console.ReadLine());

                switch (s)
                {
                    case 1:
                        {
                            action = ReadFile.ReadFile1;
                            action();
                            break;
                           
                        }

                    case 2:
                        {
                            action = GetRoot.Root;
                            action();
                            break;
                        }

                    case 3:
                        {
                            action = HtmlpGet.OutHtml;
                            action();
                            break;
                        }

                    case 4:
                        {
                            a = 0;
                            break;
                        }

                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You entered an incorrect value, try again.\n");
                            break;
                        }
                        
                }
            }
        }
    }
}
