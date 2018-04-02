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
            Layer expected = new Layer();
            expected.Name = "Cuba";

            Layer addl1 = new Layer();
            Layer addl2 = new Layer();
            Layer addl3 = new Layer();
            addl1.Name = "Canada";
            addl2.Name = "Columbia";
            addl3.Name = "Cuba";
            Map testMap = new Map();
            testMap.AddLayer(addl1);
            testMap.AddLayer(addl2);
            testMap.AddLayer(addl3);
            Layer actual =  testMap.GetLayerByName("Cuba");

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_removeLayer()
        {
            int expected = 2;
            Map testMap = new Map();
            Layer addl1 = new Layer();
            Layer addl2 = new Layer();
            Layer addl3 = new Layer();
            testMap.AddLayer(addl1);
            testMap.AddLayer(addl2);
            testMap.AddLayer(addl3);
            testMap.RemoveLayer(3);
            int actual = testMap.LayerCount;
            Assert.AreEqual(expected, actual);
        }
    }
}
