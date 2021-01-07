using CarGaleryEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarGaleryEntities.C
{
    public class Car:IEntity
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}
