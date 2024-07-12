using MediatR;
using Ordering.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Commands.Customers
{
    public  class CreateCustomerCommand:IRequest<CustomerResponse>
    {// Customer create command with CustomerResponse
       
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string ContactNumber { get; set; }
            public string Address { get; set; }
            public DateTime CreatedDate { get; set; }

            public CreateCustomerCommand()
            {
                this.CreatedDate = DateTime.Now;
            }
        
    }
}
