using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Structurs.Tests
{
    [TestClass]
    public class VectorTest
    {
        [TestMethod]
        public void Skalar_123and2_()
        {
            Vector expected = new Vector().GetVector(2, 4, 6);
            Vector OurVector = new Vector().GetVector(1, 2, 3);
            int Skalar = 2;

            Assert.AreEqual(expected, OurVector * Skalar);
        }

        [TestMethod]
        public void VectorOnVector_123and234_357()
        {
            Vector expected = new Vector().GetVector(3, 5, 7);
            Vector OurVector = new Vector().GetVector(1, 2, 3);
            Vector OurVector2 = new Vector().GetVector(2, 3, 4);

            Assert.AreEqual(expected, OurVector + OurVector2);
        }

    }
}
