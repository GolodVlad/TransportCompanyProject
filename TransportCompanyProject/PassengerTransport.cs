using System;

namespace TransportCompanyProject
{
    class PassengerTransport : Transport
    {
        int numberOfPassengerSeats;

        public PassengerTransport(double fuelConsumption, double maximumPermissibleMass, int numberOfPassengerSeats)
        {
            this.fuelConsumption = fuelConsumption;
            this.maximumPermissibleMass = maximumPermissibleMass;
            this.numberOfPassengerSeats = numberOfPassengerSeats;
            coefficientOfUtility = 80 * numberOfPassengerSeats / fuelConsumption;
        }

        public override void Info()
        {
            Console.WriteLine($"Passenger transport | " +
                $"fuel consumption: {fuelConsumption} | " +
                $"maximum permissible mass: {maximumPermissibleMass} | " +
                $"coefficientOfUtility: {coefficientOfUtility}");
        }

        public override string TypeOfTransport
        {
            get
            {
                return "Passenger";
            }
        }
    }
}
