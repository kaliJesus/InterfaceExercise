using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net.WebSockets;
using System.Reflection;
using System.Reflection.Metadata;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car()
            { Year = 2023, Make = "Tesla", Model = "R", wheels = 4, CompanyName = "Tesla", Founder = "Elon Musk" };
            var truck = new Truck()
            { Year = 2020, Make = "BMW", Model = "T", wheels = 4, CompanyName = "BMW", Founder = "Karl" };
            var suv = new SUV()
            { Year = 2020, Make = "Honda", Model = "E", wheels = 4, CompanyName = "Honda", Founder = "Soichiro" };

            var vehicles = new List<IVehicle>() { car, truck, suv };
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"wheels: {vehicle.wheels}");
               
            }
            
            var companies = new List<ICompany>() { car, truck, suv };
            foreach (var company in companies)
            {
                Console.WriteLine($"Company Name: {company.CompanyName}");
                Console.WriteLine($"Founder of Company: {company.Founder}");
               
            }

            
        }
            
           
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        
    }
}
