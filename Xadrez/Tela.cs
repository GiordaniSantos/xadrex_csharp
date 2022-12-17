using tabuleiro;

namespace Xadrez
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int x = 0; x<tabuleiro.linhas; x++)
            {
                Console.Write(8 - x + " ");
                for (int i = 0; i<tabuleiro.colunas; i++)
                {
                    if (tabuleiro.peca(x,i) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tabuleiro.peca(x,i));
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
