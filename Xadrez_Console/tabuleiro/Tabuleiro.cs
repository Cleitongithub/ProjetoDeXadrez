﻿using System;
namespace tabuleiro
{
    class Tabuleiro 
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        public Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        public Peca peca(int linha,int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca (Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public void colocarPeca(Peca p,Posicao pos)
        {
            pecas[pos.linha ,pos.coluna] = p;
            p.posicao = pos;
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha<0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna>=colunas)
            {
                return false;
            }
            public void validarPosicao(Posicao pos)
            {
                if (!posicaoValida(pos))
                {
                    throw new tabuleiroException("posicao invalida!");
                }
            }
        }
    }

}