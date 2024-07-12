using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Commands.Role.Create
{
    public class RoleCreateCommand : IRequest<int>
    {
        public string RoleName { get; set; }
    }
}
