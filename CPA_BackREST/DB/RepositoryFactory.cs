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

        public RepositoryFactory(DBUtil dbUtil)
        {
            this.dbUtil = dbUtil;
        }

        public Repository<Users> GetUserRepostory() {
            return new Repository<Users>(dbUtil.GetConn());
        }

        public Repository<Roles> GetRolesRepostory()
        {
            return new Repository<Roles>(dbUtil.GetConn());
        }

    }
}
