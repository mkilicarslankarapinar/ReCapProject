using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
 
            if (car.CarName.Length <= 2 && car.DailyPrice < 0)
            {
                
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDao.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {

            _carDao.Delete(car);

            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAllCars()
        {
            //if (DateTime.Now.Hour == 16)
            //{
            //    return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<Car>>(_carDao.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetById(int id)
        { 
            return new SuccessDataResult<List<Car>>(_carDao.GetAll(c => c.CarId == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDao.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDao.GetAll(b=> b.BrandId==brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDao.GetAll(c => c.ColorId == colorId));
        }

        public IResult Update(Car car)
        {

            _carDao.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
