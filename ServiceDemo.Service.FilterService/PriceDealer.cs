using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDemo.DAL.Inter;
using ServiceDemo.Interface;
using ServiceDemo.Model;
using ServiceDemo.Model.Reponse.Aggregate;
using ServiceDemo.Model.Reponse.Atom;
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

            List<PriceByCsDealer> listPriceByCsDealer = new List<PriceByCsDealer>();


            #region 筛选
            var priceFilter = DAL.DBAccess.DbFactory.GetPriceFilter().FilterPriceCsDealer(args);
            #endregion

            if (priceFilter.Count() > 0)
            {
                #region 取标识
                List<Int32> priceIDs = new List<int>();
                List<Int32> carIDs = new List<int>();
                List<Int32> csIDs = new List<int>();

                foreach (PriceCsFilter filter in priceFilter)
                {
                    priceIDs.Add(filter.PriceID);

                    carIDs.Add(filter.CarID);

                    csIDs.Add(filter.CsID);
                }

                #endregion


                #region 取原子数据
                var listPrice = DAL.DBAccess.DbFactory.GetPriceAtom().GetPriceListByIDs(priceIDs);

                var listCar = DAL.DBAccess.DbFactory.GetCarAtom().GetCarListByIDs(carIDs);

                var listCs = DAL.DBAccess.DbFactory.GetCarSerialAtom().GetCsListByIDs(csIDs);
                #endregion


                #region 组装
                List<PriceByCarDealer> listPriceByCarDealer = new List<PriceByCarDealer>();

                foreach (var price in listPrice)
                {
                    listPriceByCarDealer.Add(new PriceByCarDealer
                    {
                        CarInfo = listCar.SingleOrDefault<Car>(car => car.CarID == price.CarID),
                        PriceInfo = price,
                        PromotionInfo = null
                    });
                }


                foreach (PriceCsFilter filter in priceFilter)
                {
                    listPriceByCsDealer.Add(new PriceByCsDealer()
                    {
                        DealerID = args.RequestModel.DealerID,
                        CsInfo = listCs.SingleOrDefault<CarSerial>(cs => cs.CsID == filter.CsID),
                        PriceList = listPriceByCarDealer.FindAll(pp => pp.CarInfo.CsID == filter.CsID && pp.PriceInfo.DealerID == args.RequestModel.DealerID)

                    });
                }

                #endregion

            }

            return new Model.Result<List<PriceByCsDealer>>()
            {

                Status = ResultCode.OK,

                Data = listPriceByCsDealer

            };


        }
    }
}
