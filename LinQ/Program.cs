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

            #region Single()

            //var result = vehicles.Single(); // will return exception cuz have more than element 
            // Single work with just one element
            // will throw Exception if have more then one element || null 

            // string[] x = new string[] {"Name01","Name02" };
            // Console.WriteLine(x.Single());
            // will throw Exception if have more then one element || empty || null .



            //var result = vehicles.Single(c => c.Make == "Ford"); // will return Exception cuz have more then Make have the same Condition
            // Unhandled exception. System.InvalidOperationException: Sequence contains more than one matching element

            //var result = vehicles.Single(c => c.VIN == "1FTEW1C89AK439924"); // VIN is a unique Value will return
            #endregion

            #region SingleOrDefault()
            // var result = vehicles.SingleOrDefault(vehicle => vehicle.Make == "defaultCar", defaultCar);
            // if the object is empty will return the default value 

            #endregion

            // link for all return datatypes :
            // https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/introduction-to-linq-queries

            #region Data Ordering

            //var result = from car in vehicles
            //             orderby car.MaxSpeed /* descending */
            //             select car;
            //var result = vehicles.OrderBy( x => x.MaxSpeed ).ToList();

            // overload

            var result = vehicles.Order(new CarCustemIComparer());
            //int[] nums = { 10, 2, 3 };
            //var result = nums.Order();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            CarRepository.PrintCars(result);

        }
    }
}
