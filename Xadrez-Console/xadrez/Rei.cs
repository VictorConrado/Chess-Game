using tabuleiro;

namespace Xadrez_Console.xadrez
{
     class Rei : Pecas
    {
        public Rei (Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
