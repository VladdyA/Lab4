using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab4

{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Натисніть любу кнопку для того щоб побачити дані про Person");
            Console.ReadKey();

            Person p1 = new Person("Oleg", 2004);
            Person p2 = new Person("Albert", 1995);
            Person p3 = new Person("Max", 1997);
            Person p4 = new Person("Andrii", 2007);
            Person p5 = new Person("Vlad", 2003);
            Person p6 = new Person("John", 2006);

            p1.Age();
            p2.Age();
            p3.Age();
            p4.Age();
            p5.Age();
            p6.Age();

            p1.Output();
            p2.Output();
            p3.Output();
            p4.Output();
            p5.Output();
            p6.Output();

            p4.ChangeName("Stepan Radniy");
            p4.Output();

            Console.WriteLine($"Інформація про всіх осіб: {p1}; {p2}; {p3}; {p4}; {p5}; {p6}");

            p1.Comparison(p1, p4);
            p1.Comparison(p1, p6);

            Console.WriteLine("Натисніть любу кнопку для того щоб закрити консоль");
            Console.ReadKey();
        }
    }
}