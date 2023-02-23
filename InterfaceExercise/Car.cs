using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car() 
        { 


        }

        public int wheels { get; set; }
        public string Make { get; set; } = "Tesla";
        public string Model { get; set; } = "S";
        public int Year { get; set; }
        public string CompanyName { get; set; } = "Tesla";
        public string Founder { get; set; } = "We create the future";

        public void Fast()
        {
            Console.WriteLine("Cars are faster than SUV and truck");
        }
       
        public void Prefered()
        {
            Console.WriteLine("Most ppl prefer to buy Cars than trucks and SUV");
        }
           
            


    }
}
