using System;
using System.IO;
using System.Net.Http;

namespace HomeWork1Library
{ 
    public  class ReadFile
    {
        
        public static void ReadFile1()
        {
           
            Console.WriteLine("Enter the path to the file:");
            string namefile = Console.ReadLine();



            try
            {
                using (StreamReader file = new StreamReader(namefile))
                {
                    string data = file.ReadToEnd();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(data);
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You entered the wrong path.\n");
            }
        }
    }  
}
