using System;
using System.Linq;


namespace CalculandoMediaIdade
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal media = 0;
            decimal[]  idade = new decimal[8]
            
            {
                30, 42, 54, 32, 45, 65, 57,21
            };
            media = ( 30 + 42 + 54 + 32 + 45 + 65 + 57+ 21) / 8;
            Console.WriteLine("A soma da Media é:");
            Console.WriteLine(idade[1] + media);
            
               
            Console.ReadLine();
        }
    }
}
