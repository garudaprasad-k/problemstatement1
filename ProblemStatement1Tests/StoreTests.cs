using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemStatement1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement1.Tests
{
    [TestClass()]
    public class StoreTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            new PrivateType(typeof(Store)).SetStaticField("_instance", null);
            new PrivateType(typeof(PromotionFactory)).SetStaticField("_instance", null);
            new PrivateType(typeof(Billing)).SetStaticField("_instance", null);
        }

        [TestMethod()]
        public void AddProductToStoreTest_SameProductAddition_Failed()
        {
            Store.Instance.AddProductToStore("A", 50);
            Store.Instance.AddProductToStore("B", 30);
            Store.Instance.AddProductToStore("C", 20);
            Store.Instance.AddProductToStore("D", 15);


            int prodCount = Store.Instance.AllProducts.Count;
            Store.Instance.AddProductToStore("A", 25);
            Assert.AreEqual(Store.Instance.AllProducts.Count, prodCount);
            Assert.AreEqual(Store.Instance.AllProducts[0].ProductPrice, 50);
        }

        [TestMethod()]
        public void RemoveProductFromStore_ExistingProductDelete_Success()
        {
            Store.Instance.AddProductToStore("A", 50);
            Store.Instance.AddProductToStore("B", 30);
            Store.Instance.AddProductToStore("C", 20);
            Store.Instance.AddProductToStore("D", 15);


            int prodCount = Store.Instance.AllProducts.Count;
            Store.Instance.RemoveProductFromStore(Store.Instance.AllProducts[0]);
            Assert.AreEqual(Store.Instance.AllProducts.Count, prodCount-1);
        }

        [TestMethod()]
        public void RemoveProductFromStore_NonExistingProductDelete_Fail()
        {
            Store.Instance.AddProductToStore("A", 50);
            Store.Instance.AddProductToStore("B", 30);
            Store.Instance.AddProductToStore("C", 20);
            Store.Instance.AddProductToStore("D", 15);


            int prodCount = Store.Instance.AllProducts.Count;
            Store.Instance.RemoveProductFromStore(new Product("F", 12));
            Assert.AreEqual(Store.Instance.AllProducts.Count, prodCount);
        }
    }
}