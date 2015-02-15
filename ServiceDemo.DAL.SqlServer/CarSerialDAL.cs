using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDemo.DAL.Inter;
using ServiceDemo.Model.Reponse.Atom;
using Dapper;

namespace ServiceDemo.DAL.SqlServer
{
    public class CarSerialDAL : ICarSerialAtom
    {
        String connString = "server=192.168.87.63;database=PriceSearch_ver2;User ID=epuser;password=ep123";
        public Model.Reponse.Atom.CarSerial GetCsByID(int csID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CarSerial> GetCsListByIDs(List<int> csIDs)
        {
            String sql = @"SELECT [cbID]
      ,[cbName]
      ,[b_id]
      ,[m_id]
  FROM [dbo].[CarBrand] where carID in (" + String.Join<Int32>(",", csIDs) + ")";

            SqlConnection conn = new SqlConnection(connString);

            return conn.Query<CarSerial>(sql);
        }
    }
}
