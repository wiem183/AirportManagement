using System;
using System.Collections.Generic;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; } = new List<Flight>();


        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }
        public override string ToString()
        {
            return $"{base.ToString()}, BirthDate: {BirthDate}, PassportNumber: {PassportNumber}, EmailAddress: {EmailAddress}, LastName: {LastName}, FirstName: {FirstName}, TelNumber: {TelNumber}";
        }

        // Méthode pour vérifier le profil avec nom et prénom
        public bool CheckProfile(string lastName, string firstName)
        {
            return LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase) &&
                   FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase);
        }

        // Méthode pour vérifier le profil avec nom, prénom et email
        public bool CheckProfile(string lastName, string firstName, string email)
        {
            return CheckProfile(lastName, firstName) && EmailAddress.Equals(email, StringComparison.OrdinalIgnoreCase);
        }

        // Méthode pour vérifier le profil en utilisant un objet
        public bool CheckProfile(Passenger passenger)
        {
            return CheckProfile(passenger.LastName, passenger.FirstName, passenger.EmailAddress);
        }
    }
}
