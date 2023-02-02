using MyCodeLibrary;

namespace Myclient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape scrape = new Scrape();
            string thescraped = scrape.ScrapeWebpage("https://google.com");
            Console.WriteLine(thescraped);

            string filepath = @"C:\Users\emanr\OneDrive\Desktop\C#\newExample.txt";
            string thescrapedwithfile = scrape.ScrapeWebpage("https://google.com",filepath);
            Console.WriteLine("you file has succesfully been copyed to your filepath of choice {0}",filepath );
            Console.ReadLine();
        }
    }
}
