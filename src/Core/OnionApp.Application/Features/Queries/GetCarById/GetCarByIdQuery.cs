using MediatR;
using OnionApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Queries.GetCarById
{
    public class GetCarByIdQuery : IRequest<ServiceResponse<GetCarByIdViewModel>>
    {
        public Guid Id { get; set; }




    }
}
