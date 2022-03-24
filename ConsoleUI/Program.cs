using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           // CarManager();

        }

        //private static void CarManager()
        //{
        //    CarManager carManager = new(new EfCarDal());
        //    //carManager.Add(new Car { Descriptions="Volvo yeni",DailyPrice = 0, BrandId=1, ColorId=1, ModelYear="1992" });
        //    var result = carManager.GetAllByBrandId(1);
        //    if (result.Success)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.CarName);

        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}
    }
}
