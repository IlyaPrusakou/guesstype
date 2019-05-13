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
            Guid param = typeof(T).GUID;
            
            switch (param)
            {
                case Guid r when (r == typeof(string).GUID):// homework
                    string vrstring = vr.ToString();
                    if (vrstring.Length == 5) { Console.WriteLine("You have put string with 5 symbols"); }
                    else if (vrstring.Length != 5) { Console.WriteLine("I dont know what type it is"); }
                    break;
                case Guid r when r == typeof(int).GUID:// homework
                    int vrint = Convert.ToInt32(vr);
                    if (vrint > 0) { Console.WriteLine("You have put positive number"); }
                    else if (vrint <= 0) { Console.WriteLine("I dont know what type it is"); }
                    break;
                case Guid r when r == typeof(decimal).GUID:// homework
                    decimal vrdec = Convert.ToDecimal(vr);
                    if (vrdec >= 10000)
                    {
                        CultureInfo cult = CultureInfo.CreateSpecificCulture("en-US");
                        Console.WriteLine(vrdec.ToString("#,##0.00000", cult));
                    }
                    else if (vrdec < 10000) { Console.WriteLine("I dont know what type it is"); }
                    break;
                case Guid r when r == typeof(DateTime).GUID:// homework
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
            d.GuessType(ghg);// homework
            Console.ReadLine();// homework
        }
    }
}
