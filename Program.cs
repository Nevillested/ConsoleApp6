using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            XNamespace ya = "http://weather.yandex.ru/forecast";
            var t = XDocument.Load("http://export.yandex.ru/weather-ng/forecasts/29000.xml");
            var days = t.Document.Root.Elements(ya + "day");
            foreach (var day in days)
            {
                Console.WriteLine(day.Attribute("date").Value);
                Console.WriteLine(day.Element(ya + "sunrise").Value + " Восход");
                Console.WriteLine(day.Element(ya + "sunset").Value + " Закат");
                Console.WriteLine();
            }
        }
    }
}
