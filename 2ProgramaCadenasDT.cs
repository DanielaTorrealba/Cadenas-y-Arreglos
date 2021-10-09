using System;

namespace ProgramaCadenasDT
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Por favor, indique una frase:");
            
            string cadena = Console.ReadLine();
            char[] sub = {' '};
            string[] frase = cadena.Split(sub);
            for (int i = 0; i < frase.Length; i++)  
            {
                Console.WriteLine("Palabra {0} : {1}  ",(i+1), frase[i]); 
                
            }
        }
    }
}