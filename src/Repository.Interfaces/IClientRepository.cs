﻿using Models;
using System;
using System.Collections.Generic;
using System.Text;
using Repository.Interfaces.Actions;
namespace Repository.Interfaces
{
    public interface IClientRepository: IReadRepository<Client, int>
    {
    }
}
