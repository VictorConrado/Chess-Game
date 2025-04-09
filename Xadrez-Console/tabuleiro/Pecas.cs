
namespace tabuleiro
{
    abstract class Pecas
    {
        public Posicao posicao {  get; set; }
        public Cor cor {  get; set; }  
        public int qtdeMovimentos {  get; set; }
        public Tabuleiro tab { get; set; }

        public Pecas( Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdeMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            qtdeMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i =0; i<tab.linhas; i++)
            {
                for(int j=0; j<tab.colunas; j++) { 
                    if (mat [i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
