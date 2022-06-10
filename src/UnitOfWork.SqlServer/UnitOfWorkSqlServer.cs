using Common;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWork.Interfaces;

namespace UnitOfWork.SqlServer
{
    public class UnitOfWorkSqlServer : IUnitOfWork
    {
        private IConfiguration _configuration;
        public UnitOfWorkSqlServer(IConfiguration configuration=null)
        {
            _configuration = configuration;
        }
        public IUnitOfWorkAdapter Create()
        {
            var connectionString = _configuration == null ? Parameters.ConnectionString : _configuration.GetValue <string>("SqlConnection");
            return new UnitOfWorkSqlServerAdapter(Parameters.ConnectionString);
        }
    }
}
