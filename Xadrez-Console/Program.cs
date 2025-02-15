using System.Net.Http.Headers;
using tabuleiro;
namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(2,3);

            Console.WriteLine("Posição é: "+ P);
        }
    }
}
