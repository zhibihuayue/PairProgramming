using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Tests
{
    [TestClass()]
    public class GameFromTests
    {
        [TestMethod()]
        public void Button1_ClickTest()
        {

        }

        [TestMethod()]
        public void Button1_ClickTest1()
        {

            string expected = "你猜小了";
            string actual= "你猜对了";
            Assert.AreEqual(expected, actual);

        }
    }
}

namespace GameTests
{
    class GameFromTests
    {
    }
}
