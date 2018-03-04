using System;

namespace TransportCompanyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport[] arrayOfTransport =
            {
                new PassengerTransport(5, 1211, 11),
                new PassengerTransport(6, 2211, 21),
                new PassengerTransport(7, 3211, 31),
                new PassengerTransport(8, 4211, 41),
                new FreightTransport(11,3333,10,4000),
                new FreightTransport(13,4333,15,8000),
                new FreightTransport(16,5333,20,10000),
                new FreightTransport(19,6333,25,12000),
                new SpecializedFreightTransport(21, 2222, 10, 2000, "№1231 11.12.2013", "refrigerator"),
                new SpecializedFreightTransport(31, 4222, 15, 4000, "№3132 01.12.2014", "animal transporter"),
                new SpecializedFreightTransport(29, 5222, 20, 8000, "№3231 22.11.2013", "fuel transporter"),
                new SpecializedFreightTransport(51, 6222, 25, 10000, "№1211 21.12.2016", "chemicals transporter")

            };

            
            Array.Sort(arrayOfTransport, new SortByIncreasingFuelConsumption());
            Table.Show(arrayOfTransport, "Sorted by increasing fuel consumption:");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Array.Sort(arrayOfTransport, new SortByDecreasingTheUtilityCoefficient());
            Table.Show(arrayOfTransport, "Sorted by decreasing the utility coefficient:");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            int[] keys = MakeArrayOfKeys(arrayOfTransport);
            Array.Sort(keys, arrayOfTransport);
            Table.Show(arrayOfTransport, "Sorted by type of transport(SpecializedFreight > Freight > Passenger):");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Table.Show(Array.FindAll(arrayOfTransport, p => p.MaximumPermissibleMass <= 3500),
                "Trasport with maximum permissible mass <= 3500:");
            Console.WriteLine("Press any key to finish work.");
            Console.ReadKey();
        }

        private static int[] MakeArrayOfKeys(Transport[] arrayOfTran)
        {
            int[] keys = new int[arrayOfTran.Length];
            int i = 0;
            foreach (Transport trans in arrayOfTran)
            {
                if(trans is SpecializedFreightTransport)
                {
                    keys[i] = 0;
                    i++;
                }
                else if(trans is FreightTransport)
                {
                    keys[i] = 1;
                    i++;
                }
                else if(trans is PassengerTransport)
                {
                    keys[i] = 2;
                    i++;
                }
            }
            return keys;
        }
    }
}
