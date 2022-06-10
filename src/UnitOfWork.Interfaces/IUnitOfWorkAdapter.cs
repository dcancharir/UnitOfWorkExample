using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWork.Interfaces
{
    public interface IUnitOfWorkAdapter:IDisposable
    {
        IUnitOfWorkRepository Repositories { get; }
        void SaveChanges();
    }
}
