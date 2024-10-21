using MMABooksBusinessClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMABooksTests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void TestProductConstructor()
        {
            Product product1 = new Product();
            Assert.IsNotNull(product1);
            Assert.AreEqual(product1.Description, null);


        }
    }
}
