using RESTWCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTWCF.DAL
{
    public partial class Product
    {
        private static readonly Product _instance = new Product();

        private List<IProduct> products = new List<IProduct>()
        {
            new Model.Product() { ProductId = 1, Name = "Product 1", CategoryName = "Category 1", Price = 10 },
            new Model.Product() { ProductId = 1, Name = "Product 2", CategoryName = "Category 2", Price = 15 },
            new Model.Product() { ProductId = 1, Name = "Product 3", CategoryName = "Category 3", Price = 20 },
            new Model.Product() { ProductId = 1, Name = "Product 4", CategoryName = "Category 4", Price = 25 },
            new Model.Product() { ProductId = 1, Name = "Product 5", CategoryName = "Category 5", Price = 30 },
            new Model.Product() { ProductId = 1, Name = "Product 6", CategoryName = "Category 6", Price = 35 }
        };

        private Product()
        {

        }
        public static Product Instance
        {
            get { return _instance; }
        }

        public List<IProduct> ProductList
        {
            get { return products; }
        }
    }
}
