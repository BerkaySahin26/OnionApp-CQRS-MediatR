using AutoMapper;
using MediatR;
using OnionApp.Application.Interfaces.Repositories;
using OnionApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Commands.CreateCar
{
    public class CreateCarCommand : IRequest<ServiceResponse<Guid>>
    {
        public string Name { get; set; }

        public decimal Value { get; set; }

        public int Quantity { get; set; }



        public class CreateProductCommandHandler : IRequestHandler<CreateCarCommand, ServiceResponse<Guid>>
        {
            ICarRepository carRepository;
            private readonly IMapper mapper;

            public CreateProductCommandHandler(ICarRepository productRepository, IMapper mapper)
            {
                carRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<Guid>> Handle(CreateCarCommand request, CancellationToken cancellationToken)
            {
                var product = mapper.Map<Domain.Entities.Car>(request);
                await carRepository.AddAsync(product);

                return new ServiceResponse<Guid>(product.Id);
            }
        }
    }
}
