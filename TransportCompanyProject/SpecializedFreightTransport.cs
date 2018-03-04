using System;

namespace TransportCompanyProject
{
    class SpecializedFreightTransport : FreightTransport
    {
        string numberAndDateOfSurvey;
        string specialization;

        public SpecializedFreightTransport(double fuelConsumption, double maximumPermissibleMass,
            double maximumVolumeOfCargoTransported, double maximumMassOfCargoCarried,
            string numberAndDateOfSurvey, string specialization) : base(fuelConsumption, maximumPermissibleMass, 
                maximumVolumeOfCargoTransported, maximumMassOfCargoCarried)
        {
            this.numberAndDateOfSurvey = numberAndDateOfSurvey;
            this.specialization = specialization;
            coefficientOfUtility = coefficientOfUtility * 1.3;
        }

        public override void Info()
        {
            Console.WriteLine($"Specialized transport | fuel consumption: {fuelConsumption} | " +
                $"maximum permissible mass: {maximumPermissibleMass} | " +
                $"coefficientOfUtility: {coefficientOfUtility}");
        }

        public override string TypeOfTransport
        {
            get
            {
                return "Specialized freight";
            }
        }
    }
}
