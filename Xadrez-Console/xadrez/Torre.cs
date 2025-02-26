using tabuleiro;

namespace Xadrez_Console.xadrez
{
    class Torre : Pecas
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}
