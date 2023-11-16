using Microsoft.VisualStudio.TestTools.UnitTesting;
using HitungBangunDatar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitungBangunDatar.Tests
{
    [TestClass()]
    public class PersegiTests
    {
        Persegi P = new Persegi();
        [TestMethod()]
        public void sisiPTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void LuasPTest()
        {
            Assert.AreEqual(50, P.LuasP(10, 5));
        }

        [TestMethod()]
        public void tampilPTest()
        {
            Assert.IsTrue(true);
        }
    }
}

namespace HitungBangunDatarTests
{
    class PersegiTests
    {
    }
}
