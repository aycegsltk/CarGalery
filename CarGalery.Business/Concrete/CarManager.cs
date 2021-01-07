using CarGalery.Business.Abstruct;
using CarGaleryDataAccess.Abstract;
using CarGaleryEntities.C;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CarGalery.Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _car;
        public CarManager(ICarDal car)
         {
             _car = car;
         }
        public void Add(Car entity)
        {
            _car.Add(entity);
        }

        public void Delete(Car entity)
        {
            _car.Delete(entity);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
