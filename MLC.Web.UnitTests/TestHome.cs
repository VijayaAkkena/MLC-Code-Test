using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MLC.Web.Controllers;
using MLC.Web.Models;
using MLC.Web.Repositories;

namespace MLC.Web.UnitTests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestPropertyListingRepository()
        {
            var repo = new PropertyListingRepository();
            var result = repo.GetProperties(@"C:\Test\PropertyList.json");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 6);
            
                 

        }
    }
}
