using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            
            car1.BrandId = 2;
            car1.ColorId = 3;
            car1.DailyPrice = 350;
            car1.ModelName = "Koleos";
            car1.ModelYear = 2020;
            car1.Description = "Manuel/Benzin";

            ColorManager colorManager = new ColorManager(new EfColorDal());

             
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.Name);
            //}

            //CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(car1);

            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.ModelName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            //}



        }
    }
}
