using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 10;

            string caracteresPossiveis = "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ" + 
                "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ".ToLower() +
                "0123456789" + "%&#@!";

            Random sorteio = new Random();
            int numeroSorteado = 0;
            StringBuilder password = new StringBuilder();

            for (int t = 0; t < quantidade; t++)
            {
                numeroSorteado = sorteio.Next(0, caracteresPossiveis.Length - 1); //sorteio.Next = fazer sorteio  / Length tamanho total
                password.Append(caracteresPossiveis[numeroSorteado]);
            }

            Console.WriteLine(password);
            Console.ReadKey();
           

        }
    }
}
