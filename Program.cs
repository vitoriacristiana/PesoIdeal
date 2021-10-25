using System;

namespace PesoIdeal
{
    class Program
   {
        static void Main(string[] args)
       {

            double altura, pesoM , pesoF;
            string M = "M" , F = "F",sexo;

            Console.Write ("Digite sua altura em m:");
            altura = Convert.ToDouble ( Console.ReadLine ());
            Console . Write ("Sexo [M] asculino / [F]eminino:");
            sexo =  Console.ReadLine();

            pesoM = altura * 72.7-58.0;
            pesoF = altura * 62.1-44.7;

            if ( sexo ==  M )
            {
        
            Console.WriteLine ($"Seu peso ideal é:{pesoM:N1} kg");
            }

            else if (sexo == F)
            {
            Console.WriteLine ($" Seu peso ideal é:{pesoF:N1} kg");

          }
        }
    }
}
