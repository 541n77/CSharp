using System;

namespace ParOuImpar
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Bem vindo ao jogo do Par ou Ímpar------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");
            
            int valorSair = 1;
            int contadorJogador = 0;
            int contadorComputador = 0;
            
            do{
            Console.Write("Você quer par(p) ou ímpar(i)? ");
            string opcaoJogador = Console.ReadLine();

            Console.Write("Informe um número inteiro: ");
            string numeroJogadorTemp = Console.ReadLine();

            Random roleta = new Random();
            int numeroComputador = roleta.Next(100);   
            
            if (int.TryParse(numeroJogadorTemp, out int numeroJogador))
                Console.WriteLine("Seu número: " + numeroJogador);
            else{
                Console.WriteLine("Opção de número incorreta, vamos informar um número por você");
                numeroJogador = roleta.Next(100);
            }
            
            if (opcaoJogador != "p" && opcaoJogador != "i"){
                Console.WriteLine("Opção do par ou impar Inválida! Tenta novamente.");
            }
            else {
                if (((numeroJogador + numeroComputador) % 2) == 0 && opcaoJogador == "p"){
                    Console.WriteLine($"Ganhou! Jogador:{numeroJogador} Computador:{numeroComputador}");
                    contadorJogador++;
                }
                else if (((numeroJogador + numeroComputador) % 2) == 1 && opcaoJogador == "i"){
                     Console.WriteLine($"Ganhou! Jogador:{numeroJogador} Computador:{numeroComputador}");
                    contadorJogador++;
                }
                else{
                     Console.WriteLine($"Perdeu! Jogador:{numeroJogador} Computador:{numeroComputador}");
                    contadorComputador++;
                }
                
                Console.WriteLine("");
                Console.WriteLine("-- Você quer (0)Sair ou (1)Continuar ? --");
                valorSair = int.Parse(Console.ReadLine());
            }
            } while(valorSair == 1);
            
            string vencedor = contadorJogador == contadorComputador ? "Empate" : contadorJogador == contadorComputador ? "Jogador ganhou!" : "Computador ganhou!";   
            
            Console.WriteLine($"Jogador: {contadorJogador} x Computador: {contadorComputador} \n{vencedor} ");
        }
    }
}


