﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exato_Account_Module.Domain
{
    public interface IAccountTypeRepository
    {
        void Create();
        void Edit();
        void Delete();
        void List();
    }
}
