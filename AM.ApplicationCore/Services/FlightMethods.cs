using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IFlightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        
        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> flightDates = new List<DateTime>();

            //boucle for 
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                {
                    flightDates.Add(Flights[i].FlightDate);
                }
            }

            
            return flightDates;
        }

        public List<DateTime> GetFlightDatesWithForeach(string destination)
        {
            List<DateTime> flightDates = new List<DateTime>();
            foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    flightDates.Add(flight.FlightDate);
                }
            }
            return flightDates;




        }

        //question8 
        public List<Flight> GetFlights(string filterType, string filterValue)
        {
            List<Flight> filteredFlights = new List<Flight>();

            foreach (var flight in Flights)
            {
                if (filterType == "Destination" && flight.Destination == filterValue)
                {
                    filteredFlights.Add(flight);
                }
                
            }

            return filteredFlights;
        }


        


    }


}


