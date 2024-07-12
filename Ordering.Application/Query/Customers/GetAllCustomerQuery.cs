﻿using MediatR;
using Odering.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Query.Customers
{
   public  class GetAllCustomerQuery : IRequest<List<Customer>>
    {
    }
}
