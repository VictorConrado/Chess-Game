﻿using System.Net.Http.Headers;
using tabuleiro;
namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Tabuleiro tab = new Tabuleiro(8,8);

              Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
