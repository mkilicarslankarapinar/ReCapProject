using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDao _carDao;

        public CarManager(ICarDao carDao)
        {
            _carDao = carDao;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _carDao.Add(car);
            }
        }

        public void Delete(Car car)
        {
            _carDao.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDao.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDao.GetAll(c=>c.CarId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDao.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDao.GetAll(b=> b.BrandId==brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDao.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDao.Update(car);
        }
    }
}
