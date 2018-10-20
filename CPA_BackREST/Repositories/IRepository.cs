using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPA_BackREST.Repositories
{
    public interface IRepository<T>
    {
        long Save(T newObj);
        T Update(T newObj);
        void Delete(long id);
        T Get(long id);
    }
}
