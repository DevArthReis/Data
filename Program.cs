using System;

namespace Data{
    class Program{
        static void Main(string[] args){
            Console.Clear();
            //var Data = new DateTime(2024,12,18);
            var Data = DateTime.Now;
            Console.WriteLine(Data.Day);
            Console.WriteLine(Data.Year);
            Console.WriteLine(Data.Month);
            Console.WriteLine(Data.Hour);
            Console.WriteLine(Data.Minute);
            Console.WriteLine(Data.Second);
            Console.WriteLine(Data);
            Console.WriteLine($"Ao chegar as {Data} vc sera avisado ");
            Console.WriteLine($"Qual sera o dia que vc sera avisado {Data.DayOfWeek}");
            Console.WriteLine($"Qual sera o ano que vc sera avisado {Data.DayOfYear}");
            var Formatada = String.Format("{0}");
            Console.WriteLine(Formatada);
            
            
            
            
        }
    }
}