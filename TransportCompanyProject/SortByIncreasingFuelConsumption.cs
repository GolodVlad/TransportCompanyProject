using System.Collections.Generic;

namespace TransportCompanyProject
{
    class SortByIncreasingFuelConsumption : IComparer<Transport>
    {
        public int Compare(Transport trans1, Transport trans2)
        {
            if (trans1.FuelConsumption == trans2.FuelConsumption) return 0;
            else if (trans1.FuelConsumption > trans2.FuelConsumption) return 1;
            else return -1;
        }
    }
}
