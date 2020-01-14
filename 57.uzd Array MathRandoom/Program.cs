using System;

namespace _57.uzd_Array_MathRandoom
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 7);
                randomNumbers[i] = dice;
            }
            foreach (var number in randomNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
// Definēt int masīvu, kura lielums ir 10. No koda piešķirt visiem masīva elementiem vērtības. 
// Var izmantot Math.Random metodi.
