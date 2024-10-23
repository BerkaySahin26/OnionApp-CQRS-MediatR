using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Application.Features.Queries.GetCarById
{
    public class GetCarByIdViewModel
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public String Name { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

        public int Quantity { get; set; }
    }
}
