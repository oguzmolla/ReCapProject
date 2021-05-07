﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car(){Id=1, BrandId=1, ColorId=1, DailyPrice=2500, ModelYear=2015, Description="Audi a763"},
                new Car(){Id=2, BrandId=1, ColorId=1, DailyPrice=3000, ModelYear=2018, Description="Audi g3754"},
                new Car(){Id=3, BrandId=2, ColorId=2, DailyPrice=1500, ModelYear=2015, Description="Prado a743"},
                new Car(){Id=4, BrandId=2, ColorId=1, DailyPrice=3100, ModelYear=2019, Description="Prado c236"},
                new Car(){Id=5, BrandId=3, ColorId=3, DailyPrice=1800, ModelYear=2015, Description="BMW a384"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            /* new Car() dersen heap ten referasn alırsın sonra bulduğun 
            * dataya atadağında referasn yok olur gereksiz yani */
            Car carToDelete = _cars.SingleOrDefault(x => x.Id == car.Id);

            /* eğer gelen Car ı direk remove a koysaydık gelenin heap 
            * te bir ıd si olmıyacağı için listeden bulunup silinemeyecekti*/
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Car car = _cars.SingleOrDefault(x => x.Id == id);
            return car;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.Id == car.Id);
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
