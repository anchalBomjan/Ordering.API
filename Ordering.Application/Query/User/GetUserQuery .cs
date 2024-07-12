using MediatR;
using Ordering.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Query.User
{
    public class GetUserQuery : IRequest<List<UserResponseDTO>>
    {
    }
}
