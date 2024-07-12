﻿using MediatR;
using Ordering.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Commands.Role.Delete
{
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, int>
    {
        private readonly IIdentityService _identityService;

        public DeleteRoleCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }
        public async Task<int> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var result = await _identityService.DeleteRoleAsync(request.RoleId);
            return result ? 1 : 0;
        }

    }
}
