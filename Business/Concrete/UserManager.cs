using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUSerDao _userDao;

        public UserManager(IUSerDao userDao)
        {
            _userDao = userDao;
        }

        public IResult Add(User user)
        {
            _userDao.Add(user);
            return new Result(true, Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDao.Delete(user);
            return new Result(true, Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDao.GetAll(), Messages.UserListed);
        }

        public IDataResult<List<User>> GetById(int userId)
        {
            return new SuccessDataResult<List<User>>(_userDao.GetAll(p=>p.UserId==userId), Messages.UserGetByID);
        }

        public IResult Update(User user)
        {            
            _userDao.Update(user);
            return new Result(true, Messages.UserUpdated);
        }
    }
}
