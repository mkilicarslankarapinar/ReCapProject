using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDao _brandDao;

        public BrandManager(IBrandDao brandDao)
        {
            _brandDao = brandDao;
        }

        public IResult Add(Brand brand)
        {
            return new Result(true, Messages.BrandAdded);
            _brandDao.Add(brand);
        }

        public IResult Delete(Brand brand)
        {
            return new Result(true, Messages.BrandDeleted);
            _brandDao.Delete(brand);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDao.GetAll());
        }

        public IDataResult<List<Brand>> GetById(int brandId)
        {
            return new SuccessDataResult<List<Brand>>(_brandDao.GetAll(c => c.BrandId == brandId));
        }

        public IResult Update(Brand brand)
        {
            return new Result(true, Messages.BrandUpdated);
            _brandDao.Update(brand);
        }
    }
}
