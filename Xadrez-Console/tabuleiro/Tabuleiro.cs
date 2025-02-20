
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Pecas[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Pecas[linhas, colunas];
        }

        public Pecas peca( int linhas, int colunas)
        {
            return pecas[linhas, colunas];
        }
    }
}
