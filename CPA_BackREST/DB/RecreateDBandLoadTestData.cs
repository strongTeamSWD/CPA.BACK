﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPA_BackREST.DB
{
    public class RecreateDBandLoadTestData
    {
        RepositoryFactory repositoryFactory;
 
        RecreateDBandLoadTestData(RepositoryFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }
    }
}
