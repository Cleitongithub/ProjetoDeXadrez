using tabuleiro;

namespace Xadrez_Console.Xadrez
{
    class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }
        public override string ToString()
        {
            return "D";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(pos.linha, pos.coluna + 1);
            }
            //Direita
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(pos.linha, pos.coluna + 1);
            }
            //acima
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(pos.linha, pos.coluna - 1);
            }
            //abaixo
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(pos.linha, pos.coluna + 1);
            }
            //No
            pos.definirValores(posicao.linha - 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(pos.linha - 1, pos.coluna - 1);
            }
            //NE
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(pos.linha - 1, pos.coluna + 1);
            }
            //SE
            pos.definirValores(posicao.linha + 1, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(pos.linha + 1, pos.coluna + 1);
            }
            //SO
            pos.definirValores(posicao.linha + 1, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                {
                    mat[pos.linha, pos.coluna] = true;
                }
                pos.definirValores(pos.linha + 1, pos.coluna - 1);
            }
            return mat;
        }
    }
}
