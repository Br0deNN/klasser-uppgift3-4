using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser_uppgift2
{
    class namn
    {
        private string? firstname;
        private string? lastname;
        public double vikt;
        public double höjd;

        public string Firstname
        {
            get { return firstname; }

            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }

            set { lastname = value; }

        }

        public double Vikt 
        { 
            get { return vikt; }

            set {  vikt = value; } 
        }

        public double Höjd
        {
            get { return höjd; }

            set { höjd = value; }
        }

        public void metod()
        {
            Console.WriteLine("");
            Console.WriteLine($"Hej {Firstname} {Lastname}!");
            
        }

        public void metod2()
        {
            Console.WriteLine($"Ditt BMI värde är {Vikt/(Höjd*Höjd)}");
        }

        public static bool IsEighteenOrOlder(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            DateTime eighteenYearsAgo = today.AddYears(-18);

            // Kontrollera om användaren är minst 18 år gammal
            if (birthDate > eighteenYearsAgo)
            {
                return false;
            }

            return true;
        }
    }
}
