
namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Pecas[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Pecas[Linhas, Colunas];
        }
    }
}
