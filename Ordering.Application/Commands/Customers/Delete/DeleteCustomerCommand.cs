﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Commands.Customers.Delete
{
    public  class DeleteCustomerCommand : IRequest<String>
    {
        public Int64 Id { get; private set; }

        public DeleteCustomerCommand(Int64 Id)
        {
            this.Id = Id;
        }
    }
}
