﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Commands.Role.Delete
{
    public  class DeleteRoleCommand : IRequest<int>
    {

        public string RoleId { get; set; }
    }
}
