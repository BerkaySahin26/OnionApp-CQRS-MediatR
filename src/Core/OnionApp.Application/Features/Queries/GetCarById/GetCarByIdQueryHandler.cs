using AutoMapper;
using MediatR;
using OnionApp.Application.Interfaces.Repositories;
using OnionApp.Application.Wrappers;
using OnionApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Queries.GetCarById
{
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, ServiceResponse<GetCarByIdViewModel>>
    {
        ICarRepository carRepository;
        private readonly IMapper mapper;

        public GetCarByIdQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            this.carRepository = carRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<GetCarByIdViewModel>> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            var car = await carRepository.GetById(request.Id);
            var dto = mapper.Map<GetCarByIdViewModel>(car);

            return new ServiceResponse<GetCarByIdViewModel>(dto);
        }

    }
}
