using System;

namespace Polimorfismo_SobrecargaPOO_Exemplo1.classes
{
    public class Elevador
    {

        //Atributos
        private int andarAtual = 0;

        public int AndarAtual{
            get{return andarAtual;}
            set{andarAtual = value;}
        }

        private int totalAndares = 10;

        public int TotalAndares{
            get{return totalAndares;}
            set{totalAndares = value;}
        }

        private int capacidadeElevador = 15;

        public int CapacidadeElevador{
            get{return capacidadeElevador;}
            set{capacidadeElevador = value;}
        }

       public int pessoasElevador = 0;

        // public int PessoasElevador{
        //     get{return pessoasElevador;}
        //     set{pessoasElevador = value;}
        // }

        //Atributos

        //Métodos

        public string Inicializar(int capacidade , int totalDeAndares){

            
              if(pessoasElevador == 0 && andarAtual == 0){
                  return "Elevador inicializado!";
              }
            

            return "Impossivel inicializar! No elevador há pessoas ou não está no térreo";
        }

        public string Entrar(int capacidadeElevador , int pessoasElevador){
            if(pessoasElevador == capacidadeElevador){
                Console.WriteLine("Elevador lotado!");
            } else if(pessoasElevador < capacidadeElevador){
                for(int i = 0 ; i < capacidadeElevador; i++){
                    pessoasElevador = pessoasElevador++;
                }
            }

            return "-------------------------------------------------------------------";
        }

        public string Sair(int capacidadeElevador , int pessoasElevador, int respostaSair){
            if(pessoasElevador > 0 && respostaSair <= pessoasElevador){   
                int pessoasRestantes = (pessoasElevador) - (respostaSair);
                System.Console.WriteLine($"Restaram {pessoasRestantes} pessoas no elevador!");
            }


            return "------------------------------------------------------------------";
        }

        public string Subir(int andarAtual, int respostaSubir){

            if(respostaSubir > 10 || andarAtual == 10){
                System.Console.WriteLine("Não é possivel subir mais!");
            } 
                andarAtual = respostaSubir;
               
            return $"Você está no {andarAtual}° andar";      

        }

        public string Descer(int andarAtual, int respostaDescer){

            if(andarAtual == 0 || respostaDescer < 0 || respostaDescer > andarAtual){
                System.Console.WriteLine("Não é possivel descer para este andar!");
            } 

            andarAtual = respostaDescer;
            return $"Você está no {andarAtual}° andar!";
        }

        
    }
}