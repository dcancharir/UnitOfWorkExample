using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWork.Interfaces
{
    public interface IUnitOfWorkRepository
    {
        IInvoiceRepository InvoiceRepository { get; }
        IClientRepository ClientRepository { get; }
        IInvoiceDetailRepository InvoiceDetailRepository { get; }
        IProductRepository ProductRepository { get; }
    }
}
