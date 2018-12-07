using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Vega;

namespace UnitTestProject1
{
    [TestClass]
    class CRUD_TEST
    {
        RepositoryFactory factory;
        Mock mock = new Mock<DBUtil>();
        [TestMethod]
        public void testAuth() {
            var mock = new Mock<DBUtil>();
        }
    }

}
