using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;


namespace App.Core.Services
{
    public class InMemoryProductService : IProductService
    {
        private List<Product> _products;

        public InMemoryProductService() { 
             _products = new List<Product>();
            GenerateFakeProducts();

        }
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products.OrderBy(p => p.Name).ToList();
        }

        public Product GetById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Product> Search(string text, ProductCategoryEnum? category, ProductStatusEnum? status)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }

        private void GenerateFakeProducts()
        {
            _products.Clear();
            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "Laptop",
                Category = ProductCategoryEnum.Electronics,
                Price= 150000.00m,
                Stock = 10,
                Status = ProductStatusEnum.Active
            });

            _products.Add(new Product
            {
                Id = GenerateId(),
                Name = "USB-C Cable",
                Category = ProductCategoryEnum.Electronics,
                Status = ProductStatusEnum.Active,
                Price = 1200m,
                Stock = 10,
            });
        }
        private string GenerateId()
        {
             return "p-" + Guid.NewGuid().ToString("N").Substring(0, 6);
        }

    }
}
