using Microsoft.VisualStudio.TestTools.UnitTesting;
using API.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Controllers.Tests
{
    [TestClass()]
    public class PermisoControllerTests
    {
        [TestMethod()]
        public async System.Threading.Tasks.Task NewTestAsync()
        {
            var context = new PermisoDbContextTest();

            var response = await context.Permiso.AddAsync(new Models.Permiso { });



            Assert.IsNotNull(response);
            Assert.Inconclusive("TODO: crear un contexto para consumir desde permiso controller");
        }
    }
}