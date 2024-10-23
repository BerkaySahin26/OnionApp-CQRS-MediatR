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
        public string Name { get; set; }

        public string Description { get; set; } 

        public int Quentity { get; set; }
    }
}
