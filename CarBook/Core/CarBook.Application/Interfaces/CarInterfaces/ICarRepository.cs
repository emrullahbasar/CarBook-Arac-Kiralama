using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        public List<Car> GetCarsListWithBrands();
        public List<Car> GetLast5CarsWithBrands();
        int GetCarCount();
    }
}
