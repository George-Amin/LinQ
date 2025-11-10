using LinqForCSharpDevelopers;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vehicles = CarRepository.GetCars();
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
            //var Result = vehicles.FirstOrDefault(c => c.Make == "Fiat" );
            //int[] x = { };
            //var Result = x.FirstOrDefault( 1000);
            //Console.WriteLine(Result);
            //var 
            //var result = vehicles.FirstOrDefault(c => c.Make == "Fiat");
            #endregion

            #endregion


            //CarRepository.PrintCars([Result]);

        }
    }
}
