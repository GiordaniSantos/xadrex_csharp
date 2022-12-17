using tabuleiro;

namespace Xadrez
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int x = 0; x<tabuleiro.linhas; x++)
            {
                for (int i = 0; i<tabuleiro.colunas; i++)
                {
                    if (tabuleiro.peca(x,i) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.peca(x, i) + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
