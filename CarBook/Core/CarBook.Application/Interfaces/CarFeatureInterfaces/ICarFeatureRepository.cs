using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CarFeatureInterfaces
{
    public interface ICarFeatureRepository
    {
        List<CarFeature> GetCarFeaturesByCarID(int carID);

        void ChanceCarFeatureAvailableToFalse(int id);
        void ChanceCarFeatureAvailableToTrue(int id);
        void CreateCarFeatureByCar(CarFeature carFeature);

    }
}
