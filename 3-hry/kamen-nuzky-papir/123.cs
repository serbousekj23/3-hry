namespace kamen_nuzky_papir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] randomvyber = {"kamen", "nuzky", "papir"};
            
            
            
            Console.WriteLine("Kamen Nuzky Papir");
            Console.WriteLine("vyber kamen, nuzky, nebo papir:");
            string vyber = Console.ReadLine();
            if (vyber == "kamen" || vyber == "nuzky" || vyber == "papir")
            {
                Console.WriteLine("vybral jsi: " + vyber);
            }
            else
            {
             
             vyber = Console.ReadLine();
             
            }

            int randomindex = random.Next(0, randomvyber.Length);
            string pcvyber = randomvyber[randomindex];
            Console.WriteLine("pocitac vybral: " + pcvyber);

            if (vyber == pcvyber)
            { 
             Console.WriteLine("Je to remiza!");
            }

            if (vyber == "kamen" && pcvyber == "nuzky")
            {
                Console.WriteLine("vyhral jsi!");
            }

            if (vyber == "nuzky" && pcvyber == "papir")
            { 
                Console.WriteLine("vyhral jsi"); 
            }

            if (vyber == "papir" && pcvyber == "kamen")
            {
                Console.WriteLine("vyhral jsi!");
            }

            if (vyber == "kamen" && pcvyber == "papir")
            {
                Console.WriteLine("prohral jsi!");
            }

            if (vyber == "nuzky" && pcvyber == "kamen")
            {
                Console.WriteLine("prohral jsi!");
            }

            if (vyber == "papir" && pcvyber == "nuzky")
            {
                Console.WriteLine("prohral jsi!");
            }

          









        }
    }
}
