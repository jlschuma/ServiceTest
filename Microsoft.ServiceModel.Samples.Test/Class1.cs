using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ServiceModel.Samples.Test
{
    using NUnit.Framework;

    [TestFixture]
    public class MoviesTest
    {
        [Test]
        public void TransferFunds()
        {
            Movie m = new Movie();
            MoviesDAL dal = new MoviesDAL();
            //dal.GetMovies();
            /*
            Account source = new Account();
            source.Deposit(200m);

            Account destination = new Account();
            destination.Deposit(150m);

            source.TransferFunds(destination, 100m);

            Assert.AreEqual(250m, destination.Balance);
            Assert.AreEqual(100m, source.Balance);
             * */
        }
    }
}
