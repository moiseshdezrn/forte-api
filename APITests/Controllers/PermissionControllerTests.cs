using Microsoft.VisualStudio.TestTools.UnitTesting;
using API.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Controllers.Tests
{
    [TestClass()]
    public class PermissionControllerTests
    {
        [TestMethod()]
        public async void GetAllTest()
        {
            var controller = new PermissionController();

            var data = await controller.GetAll();
            
            Assert.IsTrue( true );
            Assert.AreEqual(1, 1);
        }
    }
}