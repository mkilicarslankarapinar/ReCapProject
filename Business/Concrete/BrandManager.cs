using Business.Abstract;
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

        public void Add(Brand brand)
        {
            _brandDao.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDao.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDao.GetAll();
        }

        public List<Brand> GetById(int brandId)
        {
            return _brandDao.GetAll(c => c.BrandId == brandId);
        }

        public void Update(Brand brand)
        {
            _brandDao.Update(brand);
        }
    }
}
