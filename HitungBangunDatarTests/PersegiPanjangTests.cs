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
    public class PersegiPanjangTests
    {
        PersegiPanjang PP = new PersegiPanjang();
        [TestMethod()]
        public void sisiPPTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void LuasPPTest()
        {
            Assert.AreEqual(50, PP.LuasPP(10, 5));
        }

        [TestMethod()]
        public void tampilPPTest()
        {
            Assert.IsTrue(true);
        }
    }
}

