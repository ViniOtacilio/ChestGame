using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            while (!partida.terminada)
            {
                Console.Clear();
                Tela.imprimirTabuleiro(partida.tab);

                Console.WriteLine();

                Console.Write("Digite a posição de origem: ");
                Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                Console.Write("Digite a posição de destino: ");
                Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                
                partida.executaMovimento(origem,destino);
            }
            Console.ReadLine();
        }
    }
}