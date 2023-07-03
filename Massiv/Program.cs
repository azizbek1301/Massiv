

namespace Massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massiv = new int[] { 1, 2, 5, 4, 7, 8, 96, 3, 1 };

            int result = getMaxNumber(massiv);

            Console.WriteLine(result);
        }
        static int getMaxNumber(int[] massiv) ///
        {
            int maxNumber = massiv[1];

            for (int i = 0; i < massiv.Length; i++)
            {
                if (i % 2 != 0 && massiv[i] > maxNumber)
                {
                    maxNumber = massiv[i];
                }
            }
            return maxNumber;
        }
    }
}