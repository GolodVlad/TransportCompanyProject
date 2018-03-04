namespace TransportCompanyProject
{
    abstract class Transport
    {
        protected double fuelConsumption;
        protected double maximumPermissibleMass;
        protected double coefficientOfUtility;

        public double FuelConsumption
        {
            get
            {
                return fuelConsumption;
            }
        }

        public double MaximumPermissibleMass
        {
            get
            {
                return maximumPermissibleMass;
            }
        }

        public double CoefficientOfUtility
        {
            get
            {
                return coefficientOfUtility;
            }
        }

        abstract public void Info();
        abstract public string TypeOfTransport { get; }
    }
}
