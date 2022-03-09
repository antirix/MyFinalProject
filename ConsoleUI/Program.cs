using Business.Concreate;
using DataAccess.Concreate.EntitiyFramework;
using DataAccess.Concreate.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByUnitPrice(10,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
