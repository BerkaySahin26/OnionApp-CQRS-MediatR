using AutoMapper;
using OnionApp.Application.Features.Commands.CreateCar;
using OnionApp.Application.Features.Queries.GetCarById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Mapping
{
    public class GeneralMapping : Profile
    {

        public GeneralMapping()
        {
            CreateMap<Domain.Entities.Car, Dtos.CarViewDto>()
                .ReverseMap();

            CreateMap<Domain.Entities.Car, CreateCarCommand>()
                .ReverseMap();

            CreateMap<Domain.Entities.Car, GetCarByIdViewModel>()
                .ReverseMap();
        }

    }
}
