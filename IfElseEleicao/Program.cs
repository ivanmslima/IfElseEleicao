using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.Write("Informe sua idade: ");
            int idade =int.Parse(Console.ReadLine());

            if(idade >= 70)
            {
                Console.WriteLine("Você é idoso e seu voto é facultativo");
            }
            else if(idade >= 18)
            {
                Console.WriteLine("Seu voto é obrigatório!");
            }
            else if(idade >= 16)
            {
                Console.WriteLine("Você é adolescente e seu voto é facultativo");
            }
            else
            {
                Console.WriteLine("Você não pode votar");
            }


        }
    }
}