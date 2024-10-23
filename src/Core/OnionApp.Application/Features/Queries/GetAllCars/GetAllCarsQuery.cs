using AutoMapper;
using MediatR;
using OnionApp.Application.Dtos;
using OnionApp.Application.Interfaces.Repositories;
using OnionApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Queries.GetAllCars
{
    public class GetAllCarQuery : IRequest<ServiceResponse<List<CarViewDto>>>
    {


        public class GetAllProductsQueryHandler : IRequestHandler<GetAllCarQuery, ServiceResponse<List<CarViewDto>>>
        {
            private readonly ICarRepository carRepository;
            private readonly IMapper mapper;

            public GetAllProductsQueryHandler(ICarRepository carRepository, IMapper mapper)
            {
                this.carRepository = carRepository;
                this.mapper = mapper;
            }


            public async Task<ServiceResponse<List<CarViewDto>>> Handle(GetAllCarQuery request, CancellationToken cancellationToken)
            {
                var products = await carRepository.GetAll();

                var viewModel = mapper.Map<List<CarViewDto>>(products);

                return new ServiceResponse<List<CarViewDto>>(viewModel);
            }
        }
    }
}

