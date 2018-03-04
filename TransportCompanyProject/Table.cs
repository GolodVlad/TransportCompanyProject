using System;

namespace TransportCompanyProject
{
    class Table
    {
        public static void Show(Transport[] arraOfTransport, string tableHead = "")
        {
            Console.WriteLine(tableHead);
            Console.WriteLine("╔════════════════════════╦══════════════════╦══════════════════════════╦═══════════════════════════╗");
            Console.WriteLine("║ Type of transport      ║ Fuel consumption ║ Maximum permissible mass ║ Coefficient of utility    ║");
            foreach (Transport trans in arraOfTransport)
            {
                Console.WriteLine("╠════════════════════════╬══════════════════╬══════════════════════════╬═══════════════════════════╣");
                Console.WriteLine($"║ {trans.TypeOfTransport,-23}║ " +
                    $"{trans.FuelConsumption, -17}║ " +
                    $"{trans.MaximumPermissibleMass, -25}║ " +
                    $"{trans.CoefficientOfUtility,-26}║");
            }
            Console.WriteLine("╚════════════════════════╩══════════════════╩══════════════════════════╩═══════════════════════════╝");
        }
    }
}
