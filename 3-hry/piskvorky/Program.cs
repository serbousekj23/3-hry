using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> moznosti = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0 }; 
        int vyherce = 0; 

        while (vyherce == 0 && moznosti.Contains(0)) 
        {
            // Hráč 1
            Console.WriteLine("Hrac 1, vyber pole (0-8): ");
            int hrac1 = int.Parse(Console.ReadLine());
            if (hrac1 >= 0 && hrac1 < 9 && moznosti[hrac1] == 0)
            {
                moznosti[hrac1] = 1;
            }

            
            vyherce = KontrolaVitezstvi(moznosti, 1);
            if (vyherce != 0) break;

            // Hráč 2
            Console.WriteLine("Hrac 2, vyber pole (0-8): ");
            int hrac2 = int.Parse(Console.ReadLine());
            if (hrac2 >= 0 && hrac2 < 9 && moznosti[hrac2] == 0)
            {
                moznosti[hrac2] = 2; 
            }

            
            vyherce = KontrolaVitezstvi(moznosti, 2);
        }

        
        if (vyherce == 1)
            Console.WriteLine("Hrac 1 vyhral!");
        else if (vyherce == 2)
            Console.WriteLine("Hrac 2 vyhral!");
        else
            Console.WriteLine("Hra skončila remízou.");
    }

    static int KontrolaVitezstvi(List<int> moznosti, int hrac)
    {
        
        int[,] vyhry = {
            {0, 1, 2}, 
            {3, 4, 5}, 
            {6, 7, 8}, 
            {0, 3, 6}, 
            {1, 4, 7}, 
            {2, 5, 8}, 
            {0, 4, 8}, 
            {2, 4, 6}  
        };

        
        for (int i = 0; i < vyhry.GetLength(0); i++)
        {
            if (moznosti[vyhry[i, 0]] == hrac &&
                moznosti[vyhry[i, 1]] == hrac &&
                moznosti[vyhry[i, 2]] == hrac)
            {
                return hrac;
            }
        }

        return 0;
    }
}
