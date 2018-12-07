using CPA_BackREST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega;

namespace CPA_BackREST.DB
{
    public class RepositoryFactory
    {
        private DBUtil dbUtil;
        Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public RepositoryFactory(DBUtil dbUtil)
        {
            this.dbUtil = dbUtil;
            SetAllRepositories();
        }

        private void SetAllRepositories()
        {
            repositories.Add(typeof(Users),     new Repository<Users>(dbUtil.GetConn()));
            repositories.Add(typeof(Roles),     new Repository<Roles>(dbUtil.GetConn()));
            repositories.Add(typeof(GeoTarget), new Repository<GeoTarget>(dbUtil.GetConn()));
            repositories.Add(typeof(Country),   new Repository<Country>(dbUtil.GetConn()));
            repositories.Add(typeof(City),      new Repository<City>(dbUtil.GetConn()));
            repositories.Add(typeof(Offer),     new Repository<Offer>(dbUtil.GetConn()));
            repositories.Add(typeof(Aim),       new Repository<Aim>(dbUtil.GetConn()));
        }

        public Object GetRepository(Type type)
        {
            return repositories[type];
        }
    }
}
