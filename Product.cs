using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        private int productID;
        private string productName;
        private decimal productPrice;
        private int productStock;

        public Product(int pID, string pName, decimal pPrice, int pStock)
        {
            productID = pID;
            productName = pName;
            productPrice = pPrice;
            productStock = pStock;
        }

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public decimal Price { get => productPrice; set => productPrice = value; }
        public int Stock { get => productStock; set => productStock = value; }

        public void Inc_Stock(int amount)
        {
            productStock += amount;
        }

        public void Dec_Stock(int amount)
        {
            if (productStock >= amount)
                productStock -= amount;
        }
    }
}
