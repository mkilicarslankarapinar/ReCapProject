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
    public class CustomerManager : ICustomerService
    {
        ICustomerDao _customerDao;

        public CustomerManager(ICustomerDao customerDao)
        {
            this._customerDao = customerDao;
        }

        public IResult Add(Customer customer)
        {
            _customerDao.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDao.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetById(int customerId)
        {
            return new SuccessDataResult<List<Customer>>(Messages.CustomerGetByID);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(Messages.CustomerListed);
        }

        public IResult Update(Customer customer)
        {
            _customerDao.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
