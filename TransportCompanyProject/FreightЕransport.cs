using System;

namespace TransportCompanyProject
{
    class FreightTransport : Transport
    {
        protected double maximumVolumeOfCargoTransported;
        protected double maximumMassOfCargoCarried;

        public FreightTransport(double fuelConsumption, double maximumPermissibleMass,
            double maximumVolumeOfCargoTransported, double maximumMassOfCargoCarried)
        {
            this.fuelConsumption = fuelConsumption;
            this.maximumPermissibleMass = maximumPermissibleMass;
            this.maximumVolumeOfCargoTransported = maximumVolumeOfCargoTransported;
            this.maximumMassOfCargoCarried = maximumMassOfCargoCarried;
            coefficientOfUtility = maximumMassOfCargoCarried / fuelConsumption;
        }

        public override void Info()
        {
            Console.WriteLine($"Freight transport | fuel consumption: {fuelConsumption} | " +
                $"maximum permissible mass: {maximumPermissibleMass} | " +
                $"coefficientOfUtility: {coefficientOfUtility}");
        }

        public override string TypeOfTransport
        {
            get
            {
                return "Freight";
            }
        }
    }
}
