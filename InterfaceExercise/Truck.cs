using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public Truck()
        { }


        public int wheels { get; set; }
        public string Make { get; set; } = "Tesla";
        public string Model { get; set; } = "S";
        public int Year { get; set; }
        public string CompanyName { get; set; } = "Tesla";
        public string Founder { get; set; } = "We create the future";
       

        public void Bed()
        {
            Console.WriteLine("Has big beds ");
        }
        public void TV()
        {
            Console.WriteLine("Has huge TV");
            
          
        }

       
        
    }
}



