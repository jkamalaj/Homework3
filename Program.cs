using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp14
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();



            string name;
            do
            {
                Console.WriteLine("Studenti daxil edin");
                name = Console.ReadLine();
                Console.WriteLine("Subjecti daxil edin");
                string subjet = Console.ReadLine();




            } while (string.IsNullOrWhiteSpace(name));


            string pointStr;
            double point;
            do
            {
                Console.WriteLine("Studentin pointin daxil edin");
                pointStr = Console.ReadLine();

            } while (!double.TryParse(pointStr, out point) || point < 50);


            DateTime duration1;
            string dateStr;

            do
            {
                Console.WriteLine("1. Exam baslanma tarixini qeyd edin:");
                dateStr = Console.ReadLine();

            } while (!DateTime.TryParse(dateStr, out duration1));

            DateTime duration2;

            do
            {
                Console.WriteLine("2. Exam bitme tarixni qeyd edin:");
                dateStr = Console.ReadLine();

            } while (!DateTime.TryParse(dateStr, out duration2));

            var Duration = duration2 - duration1;
            Console.WriteLine(Duration);






            
        }
    }

    
}
