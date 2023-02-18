using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICarRentalRepository
    {
        IEnumerable<CarRental> GetCarRentalList();
        void AddCarRental(CarRental carRental);
        CarRental CheckCarRentalBetweenDate(CarRental carRental);
    }
}
