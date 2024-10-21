using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using MMABooksBusinessClasses;

namespace MMABooksTests
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void TestCustomerConstructor()
        {
            Customer customer1 = new Customer();
            Assert.IsNotNull(customer1);
            Assert.AreEqual(customer1.Name, null);


        }
    }
}
