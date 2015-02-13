using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDemo.Model.Reponse.Atom;

namespace ServiceDemo.DAL.Inter
{
    public interface ICarSerialAtom
    {

        CarSerial GetCsByID(Int32 csID);

        IEnumerable<CarSerial> GetCsListByIDs(List<Int32> csIDs);
    }
}
