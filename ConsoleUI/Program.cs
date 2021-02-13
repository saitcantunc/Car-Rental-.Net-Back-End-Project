using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //brandManager.Add(new Brand { BrandId = 1, BrandName = "Fo fo" });
            //brandManager.Add(new Brand { BrandId = 2, BrandName = "do do" });
            //brandManager.Add(new Brand { BrandId = 3, BrandName = "zo zo" });
            //brandManager.Add(new Brand { BrandId = 4, BrandName = "wo wo" });

            //carManager.Add(new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 400, Description = "bmw", ModelYear = "2020" });
            //carManager.Add(new Car { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 450, Description = "audi", ModelYear = "2014" });
            //carManager.Add(new Car { CarId = 3, BrandId = 3, ColorId = 3, DailyPrice = 755, Description = "volkswagen", ModelYear = "2010" });
            //carManager.Add(new Car { CarId = 4, BrandId = 4, ColorId = 4, DailyPrice = 7000, Description = "bmw2", ModelYear = "2000" });
            //carManager.Update(new Car { CarId = 4, BrandId = 2, ColorId = 4, DailyPrice = 7000, Description = "bmw3", ModelYear = "2000" });
            //carManager.Delete(new Car { CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 450, Description = "audi", ModelYear = "2014" });
            //carManager.Update(new Car { CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 755, Description = "volkswagen", ModelYear = "2010" });

            //foreach(var car in carManager.GetAllByBrandId(2))
            //{
            //    Console.WriteLine(car.Description);
            //}


            //carManager.Add(new Car { CarId = 4,CategoryId = 2, BrandId = 2, ColorId = 4, ModelYear = 2018, DailyPrice = 1300, Description = "Nissan GTR r35 2018 Black Edition" });

            //Console.WriteLine("ADD -------------------");
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            //carManager.Update(new Car { CarId = 3, DailyPrice = 1100, Description = "Nissan GTR r35 2017 Nismo--ZAMLANDI" });

            //Console.WriteLine("UPDATE -------------------");
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}

            //carManager.Delete(new Car { CarId = 4 });

            //Console.WriteLine("DELETE -------------------");
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            CarTest();
            static void CarTest()
            {
                CarManager carManager = new CarManager(new EfCarDal());

                var result = carManager.GetCarDetails();

                if (result.Success)
                {
                    foreach (var car in result.Data)
                    {
                        Console.WriteLine(car.CarId+ "/"+ car.ColorName);
                    }
                }
                else
                {
                    Console.WriteLine(result.Message);
                }
            }


        }
    }
}
