using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDemo.Model.Reponse.Atom;
using ServiceDemo.Model.Reponse.Filter;
using ServiceDemo.Model.Request;

namespace ServiceDemo.DAL.Inter
{
    public interface IPriceAtom
    {
        Price GetPriceByID(Int32 priceID);

        IEnumerable<Price> GetPriceListByIDs(List<Int32> priceIDs);

    }

    public interface IPriceFilter
    {
        IEnumerable<PriceCsFilter> FilterPriceCsDealer(RequestListArgs<PriceByCsDealerArgs> priceArgs);
    }
}
