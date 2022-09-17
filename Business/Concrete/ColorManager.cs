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
    public class ColorManager : IColorService
    {
        IColorDao _colorDao;

        public ColorManager(IColorDao colorDao)
        {
            this._colorDao = colorDao;
        }

        public void Add(Color color)
        {
            _colorDao.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDao.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDao.GetAll();
        }

        public List<Color> GetById(int colorId)
        {
            return _colorDao.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Color color)
        {
            _colorDao.Update(color);
        }
    }
}
