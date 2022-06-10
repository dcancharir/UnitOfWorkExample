using Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
namespace Repository.SqlServer
{
    public class InvoiceRepository :Repository, IInvoiceRepository
    {
        public InvoiceRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public void Create(Invoice model)
        {
            var query = "Insert into invoices(clientid,iva,subtotal,total) output inserted.id values (@clientid,@iva,@subtotal,@total)";
            var command =CreateCommand(query);
            command.Parameters.AddWithValue("@clientid", model.ClientId);
            command.Parameters.AddWithValue("@iva", model.Iva);
            command.Parameters.AddWithValue("@subtotal", model.SubTotal);
            command.Parameters.AddWithValue("@total", model.Total);
            model.Id = (int)command.ExecuteScalar();
        }

        public Invoice Get(int id)
        {
            var result = new Invoice();
            var command = CreateCommand("Select * from invoices where id=@id");
            command.Parameters.AddWithValue("@id", id);
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                result.Id = Convert.ToInt32(reader["id"]);
                result.Iva = Convert.ToDecimal(reader["iva"]);
                result.SubTotal = Convert.ToDecimal(reader["subtotal"]);
                result.Total = Convert.ToDecimal(reader["total"]);
                result.ClientId = Convert.ToInt32(reader["clientid"]);
            }
            return result;
        }

        public IEnumerable<Invoice> GetAll()
        {
            var result = new List<Invoice>();

            var command = CreateCommand("SELECT * FROM invoices WITH(NOLOCK)");

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(new Invoice
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Iva = Convert.ToDecimal(reader["iva"]),
                        SubTotal = Convert.ToDecimal(reader["subtotal"]),
                        Total = Convert.ToDecimal(reader["total"]),
                        ClientId = Convert.ToInt32(reader["clientId"])
                    });
                }
            }

            return result;
        }

        public void Remove(int id)
        {
            var command = CreateCommand("delete from invoices where id=@id");
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
        }

        public void Update(Invoice model)
        {
            var query = "update invoices set clientid=@clientid,iva=@iva,subtotal=@subtotal,total=@total where id=@id";
            var command = CreateCommand(query);
            command.Parameters.AddWithValue("@clientid", model.ClientId);
            command.Parameters.AddWithValue("@iva", model.Iva);
            command.Parameters.AddWithValue("@subtotal", model.SubTotal);
            command.Parameters.AddWithValue("@total", model.Total);
            command.Parameters.AddWithValue("@id", model.Id);
            command.ExecuteNonQuery();
        }
    }
}
