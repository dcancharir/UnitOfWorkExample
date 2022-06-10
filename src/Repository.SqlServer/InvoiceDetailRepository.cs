using Models;
using Repository.Interfaces;
using Repository.Interfaces.Actions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
namespace Repository.SqlServer
{
    public class InvoiceDetailRepository :Repository, IInvoiceDetailRepository
    {
        public InvoiceDetailRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public InvoiceDetail Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<InvoiceDetail> GetAll()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<InvoiceDetail> GetAllByInvoiceId(int invoiceId)
        {
            var result = new List<InvoiceDetail>();
            var command = CreateCommand("Select * from invoicedetail with(nolock) where invoiceid=@invoiceid");
            command.Parameters.AddWithValue("@invoiceid", invoiceId);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(new InvoiceDetail()
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        ProductId = Convert.ToInt32(reader["productid"]),
                        Quantity = Convert.ToInt32(reader["quantity"]),
                        Iva = Convert.ToDecimal(reader["iva"]),
                        SubTotal = Convert.ToDecimal(reader["subtotal"]),
                        Total = Convert.ToDecimal(reader["total"]),
                    });
                }
            }
            return result;
        }
        public void Create(IEnumerable<InvoiceDetail> model,int invoiceId)
        {
            foreach (var detail in model)
            {
                var query = "Insert into invoicedetail(invoiceid,productid,quantity,price,iva,subtotal,total) values (@invoiceid,@productid,@quantity,@price,@iva,@subtotal,@total)";
                var command = CreateCommand(query);
                command.Parameters.AddWithValue("@invoiceid", invoiceId);
                command.Parameters.AddWithValue("@productid", detail.ProductId);
                command.Parameters.AddWithValue("@quantity", detail.Quantity);
                command.Parameters.AddWithValue("@price", detail.Price);
                command.Parameters.AddWithValue("@iva", detail.Iva);
                command.Parameters.AddWithValue("@subtotal", detail.SubTotal);
                command.Parameters.AddWithValue("@total", detail.Total);
                command.ExecuteNonQuery();
            }
        }

        public void RemoveByInvoiceId(int invoiceId)
        {
            var query = "delete from invoicedetail where invoiceid=@invoiceid";
            var command = CreateCommand(query);
            command.Parameters.AddWithValue("@invoiceid", invoiceId);
            command.ExecuteNonQuery();
        }
    }
}
