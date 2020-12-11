using System;
using Polimorfismo_SobrecargaPOO_Exemplo1.classes;

namespace Polimorfismo_SobrecargaPOO_Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(elevador.Inicializar(15,10));
            Console.ResetColor();

            Console.WriteLine("Você deseja entrar no elevador? Sim/Não");
            string resposta = Console.ReadLine();

            if(resposta == "sim" || resposta == "Sim"){
                Console.WriteLine("Quantas pessoas irão entrar no elevador?");
                elevador.pessoasElevador = int.Parse(Console.ReadLine());

                if(elevador.pessoasElevador > 0){
                    Console.WriteLine(elevador.Entrar(15, elevador.pessoasElevador));
                    Console.WriteLine($"Há {elevador.pessoasElevador} pessoas no elevador!");
                }
            }  
            int count = 0;
            do{
                Console.WriteLine("O que você deseja fazer agora? Exit {se quiser sair}");
                string resposta2 = Console.ReadLine();

                switch(resposta2){
                    case "sair":
                        Console.WriteLine("Quantas pessoas irão sair?");
                        int respostaSair = int.Parse(Console.ReadLine());

                        if(respostaSair > elevador.pessoasElevador){
                            Console.WriteLine("Não há pessoas para sair!");
                            System.Console.WriteLine(elevador.pessoasElevador);
                        }else if(respostaSair < elevador.pessoasElevador){
                            System.Console.WriteLine(elevador.Sair(15,elevador.pessoasElevador, respostaSair));
                        }
                    break;
                    case "subir":
                        System.Console.WriteLine("Deseja subir para qual andar?");
                        int respostaSubir = int.Parse(Console.ReadLine());

                        System.Console.WriteLine(elevador.Subir(elevador.AndarAtual , respostaSubir));
                    break;
                    case "descer":
                         System.Console.WriteLine("Deseja descer para qual andar?");
                        int respostaDescer = int.Parse(Console.ReadLine());

                        System.Console.WriteLine(elevador.Descer(elevador.AndarAtual , respostaDescer));
                    break;
                    case "exit":

                    break;
                } 
            }while(count < 6);    

        }
    }
}
