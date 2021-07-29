using NUnit.Framework;
using ToBeTested;

namespace NUnitPart2Jenkins
{
    [TestFixture]
    public class UnitTest1
    {
        Program p = new Program();
        [Test]
        public void TestAdd()
        {
            int val = p.Add(5, 4);
            Assert.AreEqual(9, val);
        }
    }
}
