﻿using RentalCars.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Domain.Entities
{
    public class SocailMedia : BaseEntity
    {
        public string? Name{ get; set; }
        public string? Icon { get; set; }

        public string? Url { get; set; }
    }
}
