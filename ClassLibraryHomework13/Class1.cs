using System;
using System.Net.Http;

namespace ClassLibraryHomework13
{
    public static class HtmlpGet
    {
        public static string html(string url)
        {
            HttpClient cl = new HttpClient();

            using (HttpResponseMessage response = cl.GetAsync(url).Result)
            {
                using (HttpContent content = response.Content)
                {
                    string json = content.ReadAsStringAsync().Result;
                    return json;
                }
            }
        }

        public static void OutHtml ()
        {
            string[] mass = html("https://yandex.ru/").Split(';');
            int a = 0; int count = 0; int lenmass = mass.Length;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < Math.Min(1, lenmass - 1*count); i++)
                {
                    Console.WriteLine(mass[a + i] + ';');
                }

                count++;
                a += 1;
            }
            while ( 1*count < lenmass && Req());
        }

        public static bool Req()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do you want to continue reading?");
            string ans = Console.ReadLine();

            while (ans != "Yes" && ans != "No")
            {
                Console.WriteLine("And yet do you want to continue reading?:");
                ans = Console.ReadLine();
            }
            
            if(ans == "Yes")
            {
                return true;
            }

            if (ans == "No")
            {
                return false;
            }

            return true;
        }

    }
}
