using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDemo.Model;
using ServiceDemo.Model.Reponse.Aggregate;
using ServiceDemo.Model.Reponse.Atom;
using ServiceDemo.Model.Request;

namespace ServiceDemo.Interface
{

    public interface IPrice
    {
        Result<List<PriceByCsDealer>> GetPriceListByDealerCs(RequestListArgs<PriceByCsDealerArgs> args);
    }
}
