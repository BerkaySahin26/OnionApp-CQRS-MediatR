using OnionApp.Application.Interfaces.Repositories;
using OnionApp.Domain.Entities;
using OnionApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Persistence.Repositories
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
