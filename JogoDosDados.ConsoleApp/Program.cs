using System;

namespace JogoDosDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("------ Jogo dos Dados --------");
                Console.WriteLine("------------------------------");
                Console.WriteLine();

                Console.Write("Aperte [ENTER] para lançar o dado...");
                Console.ReadLine();

                Random geradorDeDadoJogado = new Random();
                int dado = geradorDeDadoJogado.Next(1, 7);

                Console.WriteLine("------------------------------");
                Console.WriteLine($"O Dado Girou! o resultado foi: {dado}");
                Console.WriteLine("------------------------------");

                Console.WriteLine("Deseja Jogar Novamente? (S/N)");
                string continuar = (Console.ReadLine()!.ToUpper());
                if (continuar != "S")
                    break;    
            }
        }


    }//fim da classe program
}
        