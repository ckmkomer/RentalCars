﻿using RentalCars.Application.Services.Repositories;
using RentalCars.Domain.Entities;
using RentalCars.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCars.Persistence.Repositories
{
    public class ReservationRepository : EfRepositoryBase<Reservation, BaseDbContext>, IReservationRepository
    {
        public ReservationRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
