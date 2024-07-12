using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Commands.Role.Update
{
    public class UpdateRoleCommand : IRequest<int>
    {
        public string Id { get; set; }
        public string RoleName { get; set; }
    }
}
