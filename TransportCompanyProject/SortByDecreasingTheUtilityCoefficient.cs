using System.Collections.Generic;

namespace TransportCompanyProject
{
    class SortByDecreasingTheUtilityCoefficient : IComparer<Transport>
    {
        public int Compare(Transport trans1, Transport trans2)
        {
            if (trans1.CoefficientOfUtility == trans2.CoefficientOfUtility) return 0;
            else if (trans1.CoefficientOfUtility < trans2.CoefficientOfUtility) return 1;
            else return -1;
        }
    }
}
