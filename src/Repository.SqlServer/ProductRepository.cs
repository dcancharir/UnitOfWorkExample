using Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
namespace Repository.SqlServer
{
    public class ProductRepository :Repository, IProductRepository
    {
        public ProductRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public Product Get(int id)
        {
            var result = new Product();
            var command = CreateCommand("Select * from products where id=@productid");
            command.Parameters.AddWithValue("@productid", id);
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                return new Product()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Price = Convert.ToDecimal(reader["price"]),
                    Name = Convert.ToString(reader["name"]),
                };
            }
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
