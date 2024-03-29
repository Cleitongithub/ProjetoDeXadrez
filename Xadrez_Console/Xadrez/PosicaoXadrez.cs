﻿using System;
using Xadrez;
using tabuleiro;
namespace Xadrez_Console.Xadrez
{
    class PosicaoXadrez
    {
        public int coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
        

        public override string ToString()
        {
            return "" + coluna + linha; 
        }

    }
}
