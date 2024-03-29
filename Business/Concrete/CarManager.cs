﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal) {
            _carDal = carDal;
        }

       
        public void Add(Car car)
        {
            
            if (car.ModelName.Length>1 && car.DailyPrice>0 )
            {
                _carDal.Add(car);
                Console.WriteLine("Araç eklendi :"+car.ModelName);
            }else
            {            
                Console.WriteLine("Araç modeli en az 2 karakter ve günlük fiyatı 0'dan fazla olmalıdır.");
            }
            
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(p => p.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c=>c.ColorId==id);
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
