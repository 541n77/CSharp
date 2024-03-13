using System;

public class ConversorDeTemperatura
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("----- Conversor de Temperaturas ------");
        Console.WriteLine("--------------------------------------");
        
        int UserNum = 1;
        
        do{
        Console.WriteLine("");
        Console.WriteLine("Menu:");
        Console.WriteLine("1-Celsius para Farenheit");
        Console.WriteLine("2-Farenheit para Celsius");
        Console.WriteLine("3-Sair");
        Console.WriteLine("");
        Console.Write("Escolha uma opção: ");
        
        try{
            int UserInput = int.Parse(Console.ReadLine());
            UserNum = UserInput;
            
            if(UserNum < 1 || UserNum > 3){
                throw new ArgumentException("Invalid option");
            }
        }
        catch (Exception error){
            Console.WriteLine("Por Favor, insira uma opção válida");
        }
        
        switch(UserNum){
            case 1:
                Console.WriteLine("Informe a temperatura em Celsius: ");
                try{
                    if (double.TryParse(Console.ReadLine(), out double UserTemp)){
                        double result = (UserTemp * 9 / 5) + 32;
                        Console.WriteLine($"{UserTemp} é igual a {result} graus Farenheit!");
                    }
                    else
                        throw new ArgumentException("Invalid option");
                }
                catch (Exception error){
                    Console.WriteLine("Insira um valor válido");
                }
                break;
            case 2:
                Console.WriteLine("Informe a temperatura em Farenheit: ");
                try{
                    if (double.TryParse(Console.ReadLine(), out double UserTemp)){
                    double result = (UserTemp - 32) * 5 / 9;
                    Console.WriteLine($"{UserTemp} é igual a {result} graus Celsius!");
                    }
                    else
                        throw new ArgumentException("Invalid option");
                }
                catch (Exception error){
                    Console.WriteLine("Insira um valor válido");
                }
                break;
            case 3:
                UserNum = 0;
                break;
        }   
        } while (UserNum != 0);
        
        Console.WriteLine("Pressione qualquer tecla para encerrar");
        Console.ReadKey();
    }
}
