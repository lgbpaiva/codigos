using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feijoes
{
    class Program
    {
        static int qtdFeijoes;
        static int Jogo(string nome1, string nome2)
        {
            int vencedor, nRetirar, jogador;
            jogador = 1;
            while (qtdFeijoes >=1)
            {
                jogador = Turno(jogador);
                nRetirar = Jogada(jogador, nome1, nome2, qtdFeijoes);
                Update(qtdFeijoes, nRetirar);
            }
            vencedor = Resultado(jogador, nome1, nome2);
            return vencedor;
        }
        static int Turno(int j)
        {
            if (j == 2)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        static int Jogada(int j, string nome1, string nome2, int nTotal)
        {
            int nRetirar;
            if (j == 2)
            {
                Console.WriteLine(" ");
                Console.WriteLine(nome1, ", sua vez de jogar.");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine(nome2, ", sua vez de jogar.");
            }
            nRetirar = Retirada();
            return nRetirar;

        }

        static int Resultado(int j, string nome1, string nome2)
        {
            int win;
            win = Turno(j);
            if (win == 1)
            {
                Console.WriteLine("O vencedor é {0}", nome1);
            }
            else
            {
                Console.WriteLine("O vencedor é {0}", nome2);
            }
            return win;
        }
        static int Retirada()
        {
            int resp, min, max;
            Console.WriteLine("Quantos feijões quer retirar?");
            min = 1;
            max = 3;
            if (qtdFeijoes <= 2)
            {
                max = qtdFeijoes;
                Console.WriteLine("Diga um valor entre 1 e {0}", qtdFeijoes);
            }
            else
            {
                max = 3;
                Console.WriteLine("Diga um valor entre 1 e 3");
            }
            resp = int.Parse(Console.ReadLine());
            while ((resp < min) || (resp > max))
            {
                Console.WriteLine("Valor inválido");
                Console.WriteLine("Digite um valor entre {0} e {1}", min, max);
                resp = int.Parse(Console.ReadLine());
            }
            return resp;
        }
        static void Update(int nTotal, int nRetirar)
        {
            qtdFeijoes = nTotal - nRetirar;
            Console.WriteLine("A quantidade atual de feijões é: {0}", qtdFeijoes);
        }
        static void Main(string[] args)
        {
            int ganhador;
            string nome1, nome2;
            Console.WriteLine("Bem vindo ao Jogo dos Feijões! O jogo consiste em 13 feijões dentro de um pote e os jogadores se revezam tirando de 1 a 3 feijoes por vez. Aquele que retirar o último perde.");
            Console.WriteLine(" ");
            Console.Write("Jogador 1, digite seu nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Jogador 2, digite seu nome: ");
            nome2 = Console.ReadLine();
            Console.WriteLine(" ");

            qtdFeijoes = 13;

            ganhador = Jogo(nome1, nome2);
            Resultado(ganhador, nome1, nome2);
            Console.ReadKey();

        }
    }
}
