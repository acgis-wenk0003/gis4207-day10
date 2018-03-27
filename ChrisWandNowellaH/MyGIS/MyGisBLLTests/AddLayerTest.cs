using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGisBLL;

namespace MyGisBLLTests
{
    [TestClass]
    public class AddLayerTest
    {
        [TestMethod]
        public void PassingLayerTest()
        {
            int expected = 1;
            Layer testlayer = new Layer();
            Map maptest = new Map();
            maptest.AddLayer(testlayer);

            int actual = maptest.LayerCount;
            
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_layercount()
        {
            int expected = 1;
            Layer testlayer = new Layer();
            Map maptest = new Map();
            maptest.AddLayer(testlayer);

            int actual = maptest.LayerCount;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_getlayerbyname()
        {
            Layer addl1 = new Layer();
            Layer addl2 = new Layer();
            Layer addl3 = new Layer();
            addl1.Name
        }
    }
}
