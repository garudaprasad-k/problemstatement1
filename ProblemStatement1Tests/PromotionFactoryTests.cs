using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemStatement1.Tests
{
    [TestClass()]
    public class PromotionFactoryTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            new PrivateType(typeof(Store)).SetStaticField("_instance", null);
            new PrivateType(typeof(PromotionFactory)).SetStaticField("_instance", null);
            new PrivateType(typeof(Billing)).SetStaticField("_instance", null);
        }

        [TestMethod()]
        public void RemovePromotionOneTest_ExistingPromotion_Success()
        {
            Store.Instance.AddProductToStore("A", 50);
            Store.Instance.AddProductToStore("B", 30);
            Store.Instance.AddProductToStore("C", 20);
            Store.Instance.AddProductToStore("D", 15);
            Store.Instance.AddProductToStore("E", 10);

            PromotionFactory.Instance.AddNewPromotionOne("A", 3, 130);
            Assert.AreEqual(PromotionFactory.Instance.PromotionOneInstance.Data.Count, 1);
            PromotionFactory.Instance.AddNewPromotionOne("B", 2, 45);
            Assert.AreEqual(PromotionFactory.Instance.PromotionOneInstance.Data.Count, 2);

            int promCount = PromotionFactory.Instance.PromotionOneInstance.Data.Count;
            PromotionFactory.Instance.AddNewPromotionOne("B", 2, 45);
            Assert.AreEqual(PromotionFactory.Instance.PromotionOneInstance.Data.Count, promCount);


            PromotionFactory.Instance.RemovePromotionOne(PromotionFactory.Instance.PromotionOneInstance.Data[0]);
            Assert.AreEqual(PromotionFactory.Instance.PromotionOneInstance.Data.Count, promCount - 1);
        }

        [TestMethod()]
        public void RemovePromotionTwoTest_ExistingPromotion_Success()
        {
            Store.Instance.AddProductToStore("A", 50);
            Store.Instance.AddProductToStore("B", 30);
            Store.Instance.AddProductToStore("C", 20);
            Store.Instance.AddProductToStore("D", 15);
            Store.Instance.AddProductToStore("E", 10);

            PromotionFactory.Instance.AddNewPromotionTwo("C", "D", 30);
            Assert.AreEqual(PromotionFactory.Instance.PromotionTwoInstance.Data.Count, 1);

            int promCount = PromotionFactory.Instance.PromotionTwoInstance.Data.Count;
            PromotionFactory.Instance.AddNewPromotionTwo("C", "E", 45);
            Assert.AreEqual(PromotionFactory.Instance.PromotionTwoInstance.Data.Count, promCount);

            PromotionFactory.Instance.RemovePromotionTwo(PromotionFactory.Instance.PromotionTwoInstance.Data[0]);
            Assert.AreEqual(PromotionFactory.Instance.PromotionTwoInstance.Data.Count, promCount - 1);
        }
    }
}