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
    public class CarDAL : ICarAtom
    {
        String connString = "server=192.168.87.63;database=PriceSearch_ver2;User ID=epuser;password=ep123";

        public Model.Reponse.Atom.Car GetCarByID(int carID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetCarListByIDs(List<int> carIDs)
        {
            String sql = @"SELECT TOP [carID]
      ,[cbID]
      ,[carName]
      ,[carSaleState]
      ,[carExhaust]
      ,[carGearBox]
      ,[carAdvicePrice]
      ,[carYear]
  FROM [dbo].[CarBasic] where carID in (" + String.Join<Int32>(",", carIDs) + ")";

            SqlConnection conn = new SqlConnection(connString);

            return conn.Query<Car>(sql);
        }
    }
}
