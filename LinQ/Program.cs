using LinqForCSharpDevelopers;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Reflection;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vehicles = CarRepository.GetCars();
            var defaultCar = new Car(
                Id: 00,
                Make: "Default",
                Model: "Default",
                ManufactureYear: 00,
                VIN: "00",
                Color: "color",
                MaxSpeed: 000
                );
            #region Where
            //static bool IsFordAndGT(Car _car)
            //{
            //    bool fordGt = _car.Make == "Ford" && _car.Model == "GT";
            //    return fordGt;
            //}
            // LINQ Query Syntax
            //var Result =

            //    from car in vehicles
            //    where car.Make == "Ford" && (car.Model == "GT" || car.Model == "F350") && car.VIN.StartsWith("W") // recommended to use logical operators within a single where clause 
            //    //where (car.Model == "GT" || car.Model == "F350") // not recommended to have multiple where clauses
            //    select car;


            // LINQ Method Syntax


            // use the method syntax to call IsFordAndGT
            // var Result = vehicles.Where(c => c.Make == "Ford" && (c.Model == "GT" || c.Model == "F350") && c.VIN.StartsWith("W"));
            //var Result = 
            //     from c in vehicles
            //     where IsFordAndGT(c)
            //     select c;


            // use the method syntax to call IsFordAndGT
            //var Result =
            //        vehicles.Where(c => IsFordAndGT(c));

            #endregion


            #region First() , FristOrDefault()

            #region First()
            // LINQ Query Syntax
            //var Result =( from c in vehicles
            //             select c).First();


            //LinQ Method Syntax
            //var Result = vehicles.First(); 
            // var Result = vehicles.First(c => c.Make == "Volvo"); // with condition
            #endregion


            #region FirstOrDefault()
            //var Result = vehicles.FirstOrDefault(c => c.Make == "Fiat");
            //int[] x = [];
            //var Result = x.FirstOrDefault();
            //Console.WriteLine(Result); // default value of int is 0

            //vehicles = [];
            //Car defaultCar = new Car(
            //    0,
            //    "Default",
            //     "Default",
            //    0,
            //     "Default",
            //     "Default",
            //     0);
            //// default car object
            //var result = vehicles.FirstOrDefault(c=>c.Id == 1000, defaultCar); // with condition and default value

            #endregion



            #endregion

            #region Last() - LastOrDefault() .07
            #region Last()
            //var result = vehicles.Last();
            //var result = vehicles.Last(car=>car.Color == "Red"); 
            #endregion
            #region LastOrDefault()

            //var result = vehicles.LastOrDefault(c => c.Make == "George" || c.Make == "Ford", defaultCar);
            #endregion
            #endregion
            CarRepository.PrintCars([result]);

        }
    }
}
