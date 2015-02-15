using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDemo.DAL.Inter;
using ServiceDemo.Model;
using ServiceDemo.Model.Reponse.Aggregate;
using ServiceDemo.Model.Reponse.Atom;
using ServiceDemo.Model.Reponse.Filter;
using ServiceDemo.Model.Request;
using Dapper;

namespace ServiceDemo.DAL.SqlServer
{
    public class PriceDAL : IPriceAtom, IPriceFilter
    {
        String connString = "server=192.168.87.63;database=PriceSearch_ver2;User ID=epuser;password=ep123";

        public Price GetPriceByID(int priceID)
        {
            String sql = @"select [priceID],[carID]
      ,[vendorID]
      ,[vendorPrice]
      ,[promotionInfo]
      ,[smsPrice] from dbo.VendorPrice where priceID=@priceID";

            SqlConnection conn = new SqlConnection(connString);

            return conn.Query<Price>(sql, new { priceID = priceID }).FirstOrDefault();
        }

        public IEnumerable<Price> GetPriceListByIDs(List<int> priceIDs)
        {
            String sql = @"select [priceID],[carID]
      ,[vendorID]
      ,[vendorPrice]
      ,[promotionInfo]
      ,[smsPrice] from dbo.VendorPrice where priceID in (" + String.Join<Int32>(",", priceIDs) + ")";

            SqlConnection conn = new SqlConnection(connString);

            return conn.Query<Price>(sql);
        }

        public IEnumerable<PriceCsFilter> FilterPriceCsDealer(RequestListArgs<PriceByCsDealerArgs> priceArgs)
        {
            String sql = @"SELECT priceID,car.cbID,p.carID FROM dbo.VendorPrice p
INNER JOIN dbo.CarBasic car ON p.carID=car.cbID
WHERE p.vendorID=@vendorID AND p.source=1 ";

            SqlConnection conn = new SqlConnection(connString);

            return conn.Query<PriceCsFilter>(sql, new { vendorID = priceArgs.RequestModel.DealerID });


        }
    }
}
