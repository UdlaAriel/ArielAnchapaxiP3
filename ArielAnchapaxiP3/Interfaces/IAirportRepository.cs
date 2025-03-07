﻿using ArielAnchapaxiP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArielAnchapaxiP3.Interfaces
{
    internal interface IAirportRepository
    {
        public Task<bool> SaveInSQLite(AirportModel airport);
        public Task<IEnumerable<AirportModel>> GetAllAirports(AirportModel airport);
    }
}
