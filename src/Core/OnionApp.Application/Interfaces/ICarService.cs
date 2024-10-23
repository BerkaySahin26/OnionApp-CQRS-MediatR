using OnionApp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Interfaces
{
    public interface ICarService
    {
        Task<CarViewDto> GetAllCars();
    }
}
