using System;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //var data = new DateTime(2020, 10, 12, 8, 23, 14);
            var data = DateTime.Now;

            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.Millisecond);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine((int)data.DayOfWeek);

            
            var formatada = String.Format("{0:yyyy-MM-dd}", data);
            var formatada2 = String.Format("{0:yyyy/MM/dd}", data);
            var formatada3 = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data);
            var formatada4 = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", data);
            var formatada5 = String.Format("{0:t}", data);
            var formatada6 = String.Format("{0:d}", data);
            var formatada7 = String.Format("{0:T}", data);
            var formatada8 = String.Format("{0:D}", data);

            var formatada9 = String.Format("{0:r}", data);
            var formatada10 = String.Format("{0:s}", data);
            var formatada11 = String.Format("{0:u}", data);



            Console.WriteLine(formatada);
            Console.WriteLine(formatada2);
            Console.WriteLine(formatada3);
            Console.WriteLine(formatada4);
            Console.WriteLine(formatada5);
            Console.WriteLine(formatada6);
            Console.WriteLine(formatada7);
            Console.WriteLine(formatada8);
            Console.WriteLine(formatada9);
            Console.WriteLine(formatada10);
            Console.WriteLine(formatada11);


        }
    }
}
