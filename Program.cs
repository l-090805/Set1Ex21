namespace Set1Ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gandestete la un numar intre 1 si 1024.");
            Console.WriteLine("Voi incerca sa il ghicesc, punand intrebari de forma: \"Numarul este mai mic sau egal cu x?\"");
            Console.WriteLine();

            int low = 1;
            int high = 1024;
            int steps = 0;

            while(low < high)
            {
                int mid = (low + high + 1) / 2;
                Console.WriteLine($"Numarul este mai mare sau egal cu {mid} ? (da/nu)");
                string response = Console.ReadLine().ToLower();
                Console.WriteLine();

                if(response == "da")
                {
                    low = mid;
                }
                else if(response == "nu")
                {
                    high = mid - 1;
                }
                else
                {
                    Console.WriteLine("Va rog sa raspundeti doar cu \"da\" sau \"nu\".");
                    Console.WriteLine();
                    continue;
                }
                steps++;
            }
            Console.WriteLine($"Numarul la care te-ai gandit este {low}.");
            Console.WriteLine($"L-am ghicit in {steps} pasi");
        }
    }
}
