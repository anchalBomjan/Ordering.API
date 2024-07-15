using MediatR;
using Odering.Core.Entities;
using Odering.Core.Repositories.Command.Base;
using Ordering.Application.DTOs;
using Ordering.Application.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Commands.Customers
{
    public  class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CustomerResponse>
    {
        private readonly ICustomerCommandRepository _customerCommandRepository;

        public CreateCustomerCommandHandler(ICustomerCommandRepository customerCommandRepository)
        {
            _customerCommandRepository = customerCommandRepository;
        }

        public async Task<CustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customerEntity = CustomerMapper.Mapper.Map<Customer>(request);

            if (customerEntity is null)
            {
                throw new ApplicationException("There is a problem in mapper");
            }

            var newCustomer = await _customerCommandRepository.AddAsync(customerEntity);
            var customerResponse = CustomerMapper.Mapper.Map<CustomerResponse>(newCustomer);
            return customerResponse;
        }

    }
}
