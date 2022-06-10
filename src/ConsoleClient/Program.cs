using Models;
using Services;
using System;
using System.Collections.Generic;
using UnitOfWork.SqlServer;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var unitOfWork = new UnitOfWorkSqlServer();
            var invoiceService = new InvoiceService(unitOfWork);
            //var invoiceService = new InvoiceService();
           //var resul = invoiceService.Get(2);
            //var invoice = new Invoice()
            //{
            //    ClientId = 1,
            //    Id = 2,
            //    Detail = new List<InvoiceDetail>{
            //        new InvoiceDetail{
            //            ProductId=1,
            //            Quantity=5,
            //            Price=1500
            //        },
            //        new InvoiceDetail{
            //            ProductId=8,
            //            Quantity=30,
            //            Price=125
            //        }
            //    }
            //};
            //invoiceService.Create(invoice);
            invoiceService.Delete(44);
            Console.Read();
        }
    }
}
