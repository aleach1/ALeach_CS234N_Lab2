using MMABooksBusinessClasses;
using MMABooksDBClasses;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MMABooksTests
{
    public class ProductDBTests
    {
        [Test]
        public void TestGetProduct()
        {
            Product p = ProductDB.GetProduct("A4CS");
            Assert.AreEqual("A4CS", p.ProductCode);
        }

        [Test]
        public void TestCreateProduct()
        {
            Product p = new Product();
            p.Description ="Description";
            p.OnHandQuantity = 1;
            p.ProductCode = "QZ5B";
            p.UnitPrice = 56;

            bool productAdded = ProductDB.AddProduct(p);
            Assert.IsTrue(productAdded);
        }
    }
}
