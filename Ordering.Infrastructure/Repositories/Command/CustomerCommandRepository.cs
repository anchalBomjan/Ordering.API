﻿using Odering.Core.Entities;
using Odering.Core.Repositories.Command.Base;
using Ordering.Infrastructure.Data;
using Ordering.Infrastructure.Repositories.Command.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repositories.Command
{
    public class CustomerCommandRepository:CommandRepository<Customer>,ICustomerCommandRepository
    {
        public CustomerCommandRepository(OrderingContext context) : base(context)
        {

        }
    }
}
