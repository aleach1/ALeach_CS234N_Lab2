using System;
using System.Collections.Generic;
using System.Text;

namespace MMABooksBusinessClasses
{
    public class Product
    {
        public Product() { }

        public Product(string description, int onHandQuantity, string productCode, decimal unitPrice)
        {
            Description = description;
            OnHandQuantity = onHandQuantity;
            ProductCode = productCode;
            UnitPrice = unitPrice;
        }

        public string Description { get; set; }

        public int OnHandQuantity { get; set; }

        public string ProductCode { get; set; }

        public decimal UnitPrice { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
