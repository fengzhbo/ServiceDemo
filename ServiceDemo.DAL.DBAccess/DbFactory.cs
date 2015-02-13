using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDemo.DAL.Inter;

namespace ServiceDemo.DAL.DBAccess
{
    public static class DbFactory
    {

        private static SqlServer.PriceDAL priceDalSql;
        private static SqlServer.CarDAL carDalSql;
        private static SqlServer.CarSerialDAL csDalSql;

        static DbFactory()
        {
            priceDalSql = new SqlServer.PriceDAL();
            carDalSql = new SqlServer.CarDAL();
            csDalSql = new SqlServer.CarSerialDAL();
        }



        public static IPriceAtom GetPriceAtom()
        {
            return priceDalSql;
        }

        public static ICarAtom GetCarAtom()
        {
            return carDalSql;
        }

        public static ICarSerialAtom GetCarSerialAtom()
        {
            return csDalSql;
        }

        public static IPriceFilter GetPriceFilter()
        {
            return priceDalSql;
        }


    }
}
