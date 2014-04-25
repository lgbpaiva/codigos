using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            string nome, nomeMenorDano;
            nomeMenorDano = ("teste");
            int nivel, dano, raca, classe, qtdRaca1, qtdRaca2, qtdRaca3, somaDosDanos, nChar, menorDano;
            somaDosDanos = nivel = dano = raca = classe = qtdRaca1 = qtdRaca2 = qtdRaca3 = nChar = menorDano = 0;
            double mediaDano;
            //entrada de dados
            do
            {
                Console.WriteLine("Nome ou <FIM> (para sair): ");
                nome = Console.ReadLine();
                if (nome != "FIM")
                {
                    Console.WriteLine("Digite a classe do personagem. 1 - Paladino, 2 - Arqueiro, 3 - Mago: ");
                    classe = int.Parse(Console.ReadLine());
                    while ((classe != 1) && (classe != 2) && (classe != 3))
                    {
                        Console.WriteLine("Número inválido. 1 - Paladino, 2 - Arqueiro, 3 - Mago: ");
                        classe = int.Parse(Console.ReadLine());
                    }//fim enquanto
                    Console.WriteLine("Digite o nível do personagem (1-100)");
                    nivel = int.Parse(Console.ReadLine());
                    while ((nivel < 1) && (nivel > 100))
                    {
                        Console.WriteLine("Valor inválido. Nivel de 1 a 100.");
                        nivel = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Digite a raça do personagem. 1 - Humano, 2 - Anão, 3 - Elfo: ");
                    raca = int.Parse(Console.ReadLine());
                    while ((raca != 1) && (raca != 2) && (raca != 3))
                    {
                        Console.WriteLine("Número inválido. 1 - Humano, 2 - Anão, 3 - Elfo: ");
                        raca = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Digite o valor do dano do personagem:");
                    dano = int.Parse(Console.ReadLine());
                    if (raca == 1)
                    {
                        qtdRaca1++;
                    }
                    else if (raca == 2)
                    {
                        qtdRaca2++;
                    }
                    else
                    {
                        qtdRaca3++;
                    }
                    Console.WriteLine("A quantidade de personagens de cada raça é: {0} Humanos, {1} Anões e {2} Elfos.", qtdRaca1, qtdRaca2, qtdRaca3);
                    nChar++;
                    if (nChar == 1)
                    {
                        menorDano = dano;
                        nomeMenorDano = nome;
                    }
                    else
                    {
                        if (dano < menorDano)
                        {
                            menorDano = dano;
                            nomeMenorDano = nome;
                        }
                    }
                    Console.WriteLine("O Personagem de menor dano é {0}.", nomeMenorDano);
                }//fim se
            } while (nome == "FIM");
            Console.WriteLine("Obrigado");
            Console.ReadKey();
        }
    }
}
