﻿using MediatR;
using Odering.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Query.Customers
{
    public  class GetCustomerByIdHandler : IRequestHandler<GetCustomerByIdQuery, Customer>
    {

        private readonly IMediator _mediator;

        public GetCustomerByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customers = await _mediator.Send(new GetAllCustomerQuery());
            var selectedCustomer = customers.FirstOrDefault(x => x.Id == request.Id);
            return selectedCustomer;
        }
    }
}
