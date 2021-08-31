using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ArraysHomework
{
    [TestClass]
    public class ArraysHomework
    {
        [TestMethod]
        public void Arrays()
        {
            // Create an array of ints of size 100
            int[] myArray = new int[100];
            Assert.IsTrue(myArray.Length == 10);

        }
    }
}
