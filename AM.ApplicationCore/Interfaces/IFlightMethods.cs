﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
   
    public interface IFlightMethods
    {
        List<DateTime> GetFlightDates(string destination);
        List<DateTime> GetFlightDatesWithForeach(string destination);
        List<DateTime> GetFlights(string filterType, string filterValue);
    }
}

