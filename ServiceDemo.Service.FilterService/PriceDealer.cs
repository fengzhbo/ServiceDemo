using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDemo.DAL.Inter;
using ServiceDemo.Interface;
using ServiceDemo.Model.Reponse.Aggregate;
using ServiceDemo.Model.Reponse.Filter;
using ServiceDemo.Model.Request;

namespace ServiceDemo.Service.FilterService
{
    public class PriceDealer : IPrice
    {

        public Model.Result<List<PriceByCsDealer>> GetPriceListByDealerCs(RequestListArgs<Model.Request.PriceByCsDealerArgs> args)
        {
            if (args.RequestModel.CsID > 0)
            {
                throw new NotImplementedException("还没有实现");
            }

           var priceFilter = DAL.DBAccess.DbFactory.GetPriceFilter().FilterPriceCsDealer(args);

            if (priceFilter.Count() > 0)
            {
                List<Int32> priceIDs = new List<int>();
                List<Int32> carIDs = new List<int>();
                List<Int32> csIDs = new List<int>();

                foreach (PriceCsFilter filter in priceFilter)
                {
                    priceIDs.Add(filter.PriceID);

                    carIDs.Add(filter.CarID);

                    csIDs.Add(filter.CsID);

                }

                var listPrice = DAL.DBAccess.DbFactory.GetPriceAtom().GetPriceListByIDs(priceIDs);

                var listCar = DAL.DBAccess.DbFactory.GetCarAtom().GetCarListByIDs(carIDs);

                var listCs = DAL.DBAccess.DbFactory.GetCarSerialAtom().GetCsListByIDs(csIDs);


            }


        }
    }
}
