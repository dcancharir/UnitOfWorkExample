using Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
namespace Repository.SqlServer
{
    public class ClientRepository :Repository, IClientRepository
    {
        public ClientRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public Client Get(int id)
        {
            var result = new Client();
            var command = CreateCommand("Select * from clients with(nolock) where id=@id");
            command.Parameters.AddWithValue("@id", id);
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                result.Id = Convert.ToInt32(reader["id"]);
                result.Name = Convert.ToString(reader["name"]);
            }
            return result;
        }

        public IEnumerable<Client> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
