using System;

namespace ClassLibraryHomework12
{
    public static class GetRoot
    {
        public static void Root()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                double num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You cannot extract the root from a negative number.\n");
                }
                else
                {
                    double result = Math.Sqrt(num);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(result + "\n");
                }
                
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have entered an incorrect data format.\n");
            }

            
           
        }
    }
}
