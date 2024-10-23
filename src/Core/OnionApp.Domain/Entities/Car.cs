using OnionApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Domain.Entities
{
    public class Car: BaseEntity
    {
        public String Name { get; set; }

        public int Quentity { get; set; }

        public decimal Value { get; set; }
    }
}
