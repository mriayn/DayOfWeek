using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            var input = Console.ReadLine();
            //CultureInfo provider = CultureInfo.InvariantCulture;
            //var time = DateTime.ParseExact(input, "d-M- yyyy", provider);
            var day = input.Split('-');
            var newDate = new DateTime(int.Parse(day[2]), int.Parse(day[1]), int.Parse(day[0]));

            
            Console.WriteLine(newDate.DayOfWeek);
        }
    }
}
