using System;
using System.Collections.Generic;

namespace FilaDeBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int GERARSENHACOMUM = 1, GERARSENHAPRIORITARIA = 2, CHAMARSENHA = 3, ENCERRAR = 4, IMPRIMIRFILA = 5;
            
            Console.WriteLine("----------------------------------");
            Console.WriteLine("----- Programa Fila de Banco -----");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Menu:");
            Console.WriteLine("");
            
            Queue<int> filaComum = new Queue<int>();
            Queue<int> filaPrioritaria = new Queue<int>();
            int filaNum = 1;
            int opcao;

            do
            {
                Console.WriteLine($"{GERARSENHACOMUM}-Gerar uma senha comum");
                Console.WriteLine($"{GERARSENHAPRIORITARIA}-Gerar uma senha prioritária");
                Console.WriteLine($"{CHAMARSENHA}-Chamar a próxima senha");
                Console.WriteLine($"{ENCERRAR}-Sair do programa");
                Console.WriteLine($"{IMPRIMIRFILA}-Imprimir a fila");
                
                Console.WriteLine("");
                Console.Write("Informe uma opção do menu:");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case GERARSENHACOMUM:
                        filaComum.Enqueue(filaNum);
                        filaNum++;
                        break;
                    case GERARSENHAPRIORITARIA:
                        filaPrioritaria.Enqueue(filaNum);
                        filaNum++;
                        break;
                    case CHAMARSENHA:
                        if (filaPrioritaria.Count != 0){
                            Console.WriteLine("Senha: " + filaPrioritaria.Peek());
                            filaPrioritaria.Dequeue();
                        }
                        else if (filaComum.Count != 0){
                            Console.WriteLine("Senha: " + filaComum.Peek());
                            filaComum.Dequeue();
                        }
                        else
                            Console.WriteLine("Não existem mais senhas na fila de atendimento");
                        break;
                    case ENCERRAR:
                        if (filaPrioritaria.Count == 0 && filaComum.Count == 0){
                            Console.WriteLine("Atendimento encerrado.");
                            opcao = 4;
                        }
                        else if (filaPrioritaria.Count != 0 || filaComum.Count != 0){
                            Console.WriteLine("Atendimento não pode ser encerrado.");
                            opcao = 1;
                        }
                        break;
                    case IMPRIMIRFILA:
                        if (filaPrioritaria.Count > 0){
                            foreach (var numFila in filaPrioritaria)
                            {
                                Console.WriteLine($"{numFila}");
                            }
                            foreach (var numFila in filaComum)
                            {
                                Console.WriteLine($"{numFila}");
                            }
                        }
                        else if (filaPrioritaria.Count == 0 && filaComum.Count != 0){
                            foreach (var numFila in filaComum)
                            {
                                Console.WriteLine($"{numFila}");
                            }
                        }
                        else
                            Console.WriteLine("Fila Vazia");
                        break;

                }

                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
    
                } while (opcao != ENCERRAR);

            Console.WriteLine("Banco Fechou... Pressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}


