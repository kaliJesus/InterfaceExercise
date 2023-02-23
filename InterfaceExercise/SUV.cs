using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public SUV()
        {


        }

        public int wheels { get; set; }
        public string Make { get; set; } 
        public string Model { get; set; }
        public int Year { get; set; }
        public string CompanyName { get; set; } 
        public string Founder { get; set; }

        public static void People()
        {
            Console.WriteLine("SUV's carry more ppl");
        }

        public void Family()
        {
            Console.WriteLine("Great for big family");
        }



    }
   
}

