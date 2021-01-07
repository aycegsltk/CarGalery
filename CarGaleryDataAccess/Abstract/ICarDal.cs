using CarGaleryEntities.C;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGaleryDataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
    }
}
