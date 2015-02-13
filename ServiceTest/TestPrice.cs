using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceDemo.Model.Request;
using ServiceDemo.Service.FilterService;

namespace ServiceTest
{
    [TestClass]
    public class TestPrice
    {
        [TestMethod]
        public void TestPriceByCsDealer()
        {
            RequestListArgs<PriceByCsDealerArgs> args = new RequestListArgs<PriceByCsDealerArgs>()
            {
                RequestModel = new PriceByCsDealerArgs
                {
                    DealerID = 50002218,
                    CsID = 2593
                },
                StartNum = 0,
                EndNum = 0

            };

            Assert.IsNotNull(new PriceDealer().GetPriceListByDealerCs(args));

            


        }
    }
}
