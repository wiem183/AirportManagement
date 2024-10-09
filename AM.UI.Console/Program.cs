// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using System; // Ajoute cet espace de noms pour utiliser System.Console

namespace AM.UI.ConsoleApp // Change 'Console' à autre chose pour éviter le conflit
{
    public class Program
    {
        // Méthode Main, point d'entrée du programme
        public static void Main(string[] args)
        {
            // Création d'un objet de la classe PlaneService
            PlaneService planeService = new PlaneService();

            // Appel de la méthode CreatePlane pour créer et initialiser un objet Plane
            planeService.CreatePlane();
        }
    }

    public class PlaneService
    {
        public void CreatePlane()
        {

            Plane myPlane = new Plane(PlanType.Boing, 180, new DateTime(2020, 5, 15));

            // Affichage des informations du Plane
            Console.WriteLine(myPlane.ToString());

            Passenger wiemPassenger = new Passenger
            {
                FirstName = "Wiem",
                LastName = "Errouissi",
                EmailAddress = "wiem.errouissi@esprit.tn"
            };

            // Vérification du profil avec nom et prénom
            bool isProfileValid1 = wiemPassenger.CheckProfile("Errouissi", "Wiem");

            // Vérification du profil avec nom, prénom et email
            bool isProfileValid2 = wiemPassenger.CheckProfile("Errouissi", "Wiem", "wiem.errouissi@example.com");

            // Vérification du profil avec un objet passager
            Passenger passengerToCompare = new Passenger
            {
                FirstName = "Wiem",
                LastName = "Errouissi",
                EmailAddress = "wiem.errouissi@esprit.tn"
            };
            bool isProfileValid3 = wiemPassenger.CheckProfile(passengerToCompare);

            // Affichage des résultats
            Console.WriteLine($"Profile valid (2 params): {isProfileValid1}");
            Console.WriteLine($"Profile valid (3 params): {isProfileValid2}");
            Console.WriteLine($"Profile valid (object): {isProfileValid3}");

            Passenger passenger = new Passenger();
            Staff staffMember = new Staff();
            Traveller traveller = new Traveller();


            passenger.PassengerType();

            staffMember.PassengerType();



            //FlightMethods flightMethods = new FlightMethods();
            //flightMethods.Flights = TestData.listFlights;
            // var flightDates = flightMethods.GetFlightDates("Madrid");

            // foreach (var date in flightDates)
            // {
            //Console.WriteLine($"Flight Date: {date}");
            //}/

            FlightMethods flightMethods = new FlightMethods();
            flightMethods.Flights = TestData.listFlights;
    
            string filterType = "Destination";
            string filterValue = "Paris";

            var filteredFlights = flightMethods.GetFlights(filterType, filterValue);

            // Afficher les vols filtrés
            Console.WriteLine($"Flights filtered by {filterType} = {filterValue}:");
            foreach (var flight in filteredFlights)
            {
                Console.WriteLine($"Flight to {flight.Destination} on {flight.FlightDate}");
            }
        }
    }
}
            



    
    





