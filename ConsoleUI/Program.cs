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

            //Car car = new Car()
            //{
            //    Id = 6,
            //    BrandId = 2,
            //    ColorId = 2,
            //    DailyPrice = 0,
            //    Description = "Prado a9586",
            //    ModelYear = 2019
            //};

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Description);
            //}

            //carManager.Add(car);
            //Console.WriteLine();
            //Console.WriteLine("yeni car eklendi  :" + car.Description);

            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.CarName+" Marka :  " +item.BrandName+" Renk :  "+ item.ColorName);
            }

            //delete a car - Prado a743
            //Car carToDelete = new Car() { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 1500, ModelYear = 2015, Description = "Prado a743" };

            //carManager.Delete(carToDelete);
            //Console.WriteLine();
            //Console.WriteLine("Araba silindi : "+ carToDelete.Description);

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Description);
            //}

            //update audi a763s daily price

            //Car carToUpdate = new Car() { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 2000, ModelYear = 2015, Description = "Audi a876" };
            //carManager.Update(carToUpdate);

            //Console.WriteLine();
            //Console.WriteLine("Araba güncellendi : "+carToUpdate.Description);

            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Description);
            //}

            ////Get By Id 
            //Console.WriteLine();
            //Console.WriteLine("Id si 1 olan ürün");
            //Console.WriteLine(carManager.GetById(1).Description);
        }
    }
}
