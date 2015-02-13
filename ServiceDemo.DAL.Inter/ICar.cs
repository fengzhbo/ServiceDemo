using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDemo.Model.Reponse.Atom;

namespace ServiceDemo.DAL.Inter
{
    public interface ICarAtom
    {
        Car GetCarByID(Int32 carID);

        IEnumerable<Car> GetCarListByIDs(List<Int32> carIDs);
    }
}
