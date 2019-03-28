using Microsoft.VisualStudio.TestTools.UnitTesting;
using 四则运算;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 四则运算.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            int i = 0;
            if (Program.arrayList.Contains('.'))
                i = 1;
            Assert.IsTrue(i == 0);
            //Assert.Fail();
        }

        [TestMethod()]
        public void ChuTest()
        {
            //Assert.Fail();
        }
    }
}