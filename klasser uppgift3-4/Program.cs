using klasser_uppgift2;
using System;
namespace Uppgift2
{
    public class Program
    {
        public static void Main()
        {
            namn p = new namn();

            Console.WriteLine("Vad heter du i förnamn?");
            p.Firstname = Console.ReadLine();
            Console.WriteLine("Vad heter du i efternamn?");
            p.Lastname = Console.ReadLine();
            p.metod();

            Console.WriteLine("Vilket år är du född?");
            int år = int.Parse(Console.ReadLine());

            Console.WriteLine("Vilken månad är du född?");
            int månad = int.Parse(Console.ReadLine());

            Console.WriteLine("Vilken dag är du född?");
            int dag = int.Parse(Console.ReadLine());

            DateTime birthDate = new DateTime(år, månad, dag);
            Console.WriteLine(namn.IsEighteenOrOlder(birthDate));

            Console.WriteLine("Hur mycket väger du i kg?");
            p.Vikt = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur lång är du i meter?");
            p.Höjd = double.Parse(Console.ReadLine());

            p.metod2();





        }
    }
}