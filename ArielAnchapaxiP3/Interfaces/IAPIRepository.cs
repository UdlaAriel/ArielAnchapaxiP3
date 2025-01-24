using ArielAnchapaxiP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArielAnchapaxiP3.Interfaces
{
    internal interface IAPIRepository
    {
        public Task<AirportModel> GetResponseFromAPi(string name);
    }
}
