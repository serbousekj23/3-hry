namespace sibenice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sibenice! Hádej slovo: ");
            string[] slova = File.ReadAllLines(@"slova.txt");
            Random random = new Random();

            int index = random.Next(slova.Length);
            string hernislovo = slova[index];
            List<char> pismenaslova = new List<char>(hernislovo.ToCharArray());
            string carky = new string('_', hernislovo.Length);
            Console.WriteLine(carky);
            
            
            while (carky.Contains('_'))
            {
                Console.Write("zadej písmeno: ");
                string input = Console.ReadLine();
                
                if (input.Length == 1 && char.TryParse(input, out char napsanepismeno))
                {
                    if (pismenaslova.Contains(napsanepismeno))
                    {
                        for (int i = 0; i < pismenaslova.Count; i++)
                        {
                            if (pismenaslova[i] == napsanepismeno)
                            {
                                carky[i] = napsanepismeno;
                            }
                        }
                        Console.WriteLine("sigma" + new string(carky.ToArray()));
                    }
                    else
                    {
                        Console.WriteLine("spatne");
                }    }
                
                else
                {
                    Console.WriteLine("zadej pouze 1 pismeno");
                }


                
            }  
            
                
            
            
            

            
            

            

            

            
            
            
            
            
            

        }
    }
}
