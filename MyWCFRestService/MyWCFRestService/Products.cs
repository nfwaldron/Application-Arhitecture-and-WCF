using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWCFRestService
{
    public partial class Products
    {
        private static readonly Products _instance = new Products();

        private List<ProductDataContract> products = new List<ProductDataContract>()
        {
            new ProductDataContract() { ProductId = 1, Name = "Product 1", CategoryName = "Category 1", Price = 10 },
            new ProductDataContract() { ProductId = 1, Name = "Product 2", CategoryName = "Category 2", Price = 15 },
            new ProductDataContract() { ProductId = 1, Name = "Product 3", CategoryName = "Category 3", Price = 20 },
            new ProductDataContract() { ProductId = 1, Name = "Product 4", CategoryName = "Category 4", Price = 25 },
            new ProductDataContract() { ProductId = 1, Name = "Product 5", CategoryName = "Category 5", Price = 30 },
            new ProductDataContract() { ProductId = 1, Name = "Product 6", CategoryName = "Category 6", Price = 35 }
        };

        private Products()
        {

        }
        public static Products Instance
        {
            get { return _instance; }
        }

        public List<ProductDataContract> ProductList
        {
            get { return products; }
        }


    }
}