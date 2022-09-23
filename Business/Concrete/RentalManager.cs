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
    public class RentalManager : IRentalService
    {
        IRentalDao _rentalDao;

        public RentalManager(IRentalDao rentalDao)
        {
            _rentalDao = rentalDao;
        }

        public IResult Add(Rental rental)
        {
            _rentalDao.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDao.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetById(int rentalId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDao.GetAll(p => p.RentalId == rentalId));
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDao.GetAll());
        }

        public IResult Update(Rental rental)
        {
            _rentalDao.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
