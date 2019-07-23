using System;
using tabuleiro;
using Xadrez;
using Xadrez_Console.Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.WriteLine();

        }
    }
}
