using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace guesstype
{
    class GenericClass
    {
        public void GuessType<T>(T vr) // homework
        {
            // У меня  стояла версия языка 7.0, a прямое  сравнение переменной vr c 
            //переменной r работает только на версии 7.1 и выше.

            switch (vr)
            {
                case string r:
                    if (r.Length == 5) { Console.WriteLine("You have put string with 5 symbols"); }
                    else if (r.Length != 5) { Console.WriteLine("I dont know what type it is"); }
                    break;
                case int r:
                    if (r > 0) { Console.WriteLine("You have put positive number"); }
                    else if (r <= 0) { Console.WriteLine("I dont know what type it is"); }
                    break;
                case decimal r:
                    if (r >= 10000) { Console.WriteLine("Decimal"); }
                    if (r < 10000) { Console.WriteLine("I dont know what type it is"); }
                    break;
                case DateTime r:
                    Console.WriteLine("You have put Date"); 
                    break;
                default:
                    Console.WriteLine("I dont know what type it is");
                    break;
            }
        }
    }
        
    class Program
    {
        
        
        static void Main(string[] args)
        {
            decimal ghg = 13545.666666666666666666m;// homework
            GenericClass d = new GenericClass();// homework
            d.GuessType("dfsdf");// homework
            Console.ReadLine();// homework
        }
    }
}
