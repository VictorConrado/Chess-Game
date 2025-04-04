
namespace tabuleiro
{
     class Pecas
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
    }
}
