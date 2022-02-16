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


            funcoesAdicionais();

            compararDatas();

            globalizacao();

            TimeZone();

            TimeSpan();
        }

        static void funcoesAdicionais()
        {
            var data = DateTime.Now;
            Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddDays(-12));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1));
        }

        static void compararDatas()
        {
            var data = DateTime.Now;

            //DATA NULL
            //DateTime? data = null;

            if(data.Date == DateTime.Now.Date) 
            {
                Console.WriteLine("É igual");
            }
            
            Console.WriteLine(data);
        }

        static void globalizacao()
        {
            var pt = new System.Globalization.CultureInfo("pt-BR");
            var enUs = new System.Globalization.CultureInfo("en-US");
            var de = new System.Globalization.CultureInfo("en-DE");
            var atual = System.Globalization.CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("d", enUs));
            //Console.WriteLine(string.Format("{0:D}", DateTime.Now));
        }

        static void TimeZone()
        {
            var utcDate = DateTime.UtcNow;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate);
            Console.WriteLine(utcDate.ToLocalTime());


            //var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

            //var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);

            //Console.WriteLine(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach(var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("____________");
            }
        }

        static void TimeSpan()
        {
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoSegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);


            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new System.TimeSpan(12, 0, 0)));
        }
    }
}
