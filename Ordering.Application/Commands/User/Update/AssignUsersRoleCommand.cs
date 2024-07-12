﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Commands.User.Update
{ 
    public class AssignUsersRoleCommand : IRequest<int>
    {
        public string UserName { get; set; }
        public IList<string> Roles { get; set; }
    }
}
