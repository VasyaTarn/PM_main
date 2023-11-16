using App;

namespace Test
{
    [TestClass]
    public class HelperTest
    {
        [TestMethod]
        public void EllipsisTest()
        {
            Helper helper = new Helper();
            Assert.IsNotNull(helper, "new Helper() should not be null");
            Assert.AreEqual("He...", helper.Ellipsis("Hello, world", 6));
            //Assert.AreEqual("Hel...", helper.Ellipsis("Hello, world", 6));
        }
    }
}