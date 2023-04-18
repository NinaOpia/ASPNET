using System;
using System.Collections.Generic;

namespace Testing.Models
{
	public interface IProductRepository
	{
        public void DeleteProduct(Product product);

        public IEnumerable<Product> GetAllProducts();

		public Product GetProduct(int id);

		public void UpdateProduct(Product product);

		public void InsertProduct(Product productToInsert);

		public IEnumerable<Category> GetCategories();

		public Product AssignCategory();

    }
}

