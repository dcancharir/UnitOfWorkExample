using Models;
using System;
using System.Collections.Generic;
using System.Text;
using Repository.Interfaces.Actions;
namespace Repository.Interfaces
{
    public interface IInvoiceDetailRepository:IReadRepository<InvoiceDetail,int>
    {
        IEnumerable<InvoiceDetail> GetAllByInvoiceId(int invoiceId);
        void Create(IEnumerable<InvoiceDetail> model, int invoiceId);
        void RemoveByInvoiceId(int invoiceId);
    }
}
