using System.Net.Http.Headers;
using tabuleiro;
using xadrez;
using Xadrez_Console.xadrez;
namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try { 
            //Tabuleiro tab = new Tabuleiro(8,8);

            //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 3));
            //tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 4));
            //tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 7));

            //Tela.imprimirTabuleiro(tab);
            //}
            //catch (TabuleiroException ex)
            //{
            //  Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();

            PosicaoXadrez pos = new PosicaoXadrez('c',7);

            //Console.Write(pos);
           Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
        }
    }
}
