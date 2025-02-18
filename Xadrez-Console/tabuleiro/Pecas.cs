
namespace tabuleiro
{
     class Pecas
    {
        public Posicao posicao {  get; set; }
        public Cor cor {  get; set; }  
        public int qtdeMovimentos {  get; set; }
        public Tabuleiro tabuleiro { get; set; }

        public Pecas(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.qtdeMovimentos = 0;
        }
    }
}
