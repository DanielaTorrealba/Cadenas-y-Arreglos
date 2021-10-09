using System;

namespace ProgramaArreglosDT
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] V = new float[] {4,12,68,32,25};
            float M = 0;
            int Cant = V.Length;

            for(int i = 0; i < Cant; i++)
            {
                M = M + V[i];
            }

            M = M/Cant;
            
            Console.WriteLine("Total media de los valores dados: " + M);
        }
    }
}