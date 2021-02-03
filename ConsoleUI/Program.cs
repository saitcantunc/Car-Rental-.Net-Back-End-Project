using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Add(new Car { Id = 4,CategoryId = 2, BrandId = 2, ColorId = 4, ModelYear = 2018, DailyPrice = 1300, Description = "Nissan GTR r35 2018 Black Edition" });

            Console.WriteLine("ADD -------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Update(new Car { Id = 3, DailyPrice = 1100, Description = "Nissan GTR r35 2017 Nismo--ZAMLANDI" });

            Console.WriteLine("UPDATE -------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Delete(new Car { Id = 4 });

            Console.WriteLine("DELETE -------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
