using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingTeamCity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTeamCity.Models.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void PersonTest()
        {
            var p = new Person("Me");

            Assert.IsNotNull(p.Name);
        }
    }
}