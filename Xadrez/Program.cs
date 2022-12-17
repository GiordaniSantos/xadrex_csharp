using tabuleiro;
using xadrez;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

           
            Tabuleiro tab = new Tabuleiro(8,8);
          
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0,0));
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
            tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 9));

            Tela.imprimirTabuleiro(tab);

            Console.WriteLine();
            Console.WriteLine();
            PosicaoXadrez pos = new PosicaoXadrez('a',1);
            Console.WriteLine(pos);

            Console.ReadLine();
            }catch(TabuleiroException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}