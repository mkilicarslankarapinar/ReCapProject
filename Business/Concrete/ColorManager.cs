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
    public class ColorManager : IColorService
    {
        IColorDao _colorDao;

        public ColorManager(IColorDao colorDao)
        {
            this._colorDao = colorDao;
        }

        public IResult Add(Color color)
        {
            return new Result(true, Messages.CarDeleted);
            _colorDao.Add(color);
        }

        public IResult Delete(Color color)
        {
            return new Result(true, Messages.CarDeleted);
            _colorDao.Delete(color);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDao.GetAll());
        }

        public IDataResult<List<Color>> GetById(int colorId)
        {
            return new SuccessDataResult<List<Color>>(_colorDao.GetAll(c => c.ColorId == colorId));
        }

        public IResult Update(Color color)
        {
            return new Result(true, Messages.CarDeleted);
            _colorDao.Update(color);
        }
    }
}
