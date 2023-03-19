using System;

namespace atividade_class_carro
{
    public class Carro
    {
        // Atributos da classe
        public string marca;
        public string modelo;
        public int ano;
        public int velocidadeAtual;

        //Métodos da classe
            //Método de acelerar o carro
        public int Acelerar(int kmh)
        {
            return velocidadeAtual = velocidadeAtual + kmh;
        }

            //Método de parar o carro
        public void Parar()
        {
            velocidadeAtual = 0;
        }

            //Método de exibir informações sobre o carro
        public void Informacoes()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Ano: " + ano);
            Console.WriteLine("Velocidade Atual: " + velocidadeAtual + "km/h");
            Console.WriteLine();
        }

    }

    //Executando objeto com a classe de "Carro"
     class Program
    {
        static void Main(string[] args)
        {
            //Criando primeiro objeto da classe "Carro" e adotando os métodos Acelerar e depois parar

            //Criando objeto da classe "Carro"
            Carro carro1 = new Carro();

            //Declarando atributos
            carro1.marca = "Nissan";
            carro1.modelo = "GTR";
            carro1.ano = 2020;
            carro1.velocidadeAtual = 50;

            //Chamando métodos
            //Exibindo informações
            carro1.Informacoes();

                //Acelerando
            carro1.Acelerar(50);

                //Exibindo informações
            carro1.Informacoes();

                //Parando
            carro1.Parar();

                //Exibindo informações
            carro1.Informacoes();

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            //Criando vetores
            Carro[] carros = new Carro[3];

            //Populando primeiro vetor da lista com as caracteristicas e métodos da classe "Carro"
            carros[0] = new Carro();
            carros[0].marca = "Bugatti";
            carros[0].modelo = "Chiron";
            carros[0].ano = 2018;
            carros[0].velocidadeAtual = 0;
            carros[0].Informacoes();
            carros[0].Acelerar(20);
            carros[0].Informacoes();

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            //Populando segundo vetor da lista com as caracteristicas e métodos da classe "Carro"
            carros[1] = new Carro();
            carros[1].marca = "Ferrari";
            carros[1].modelo = "F40";
            carros[1].ano = 1989;
            carros[1].velocidadeAtual = 0;
            carros[1].Informacoes();
            carros[1].Acelerar(40);
            carros[1].Informacoes();

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            //Populando terceiro vetor da lista com as caracteristicas e métodos da classe "Carro"
            carros[2] = new Carro();
            carros[2].marca = "Ford";
            carros[2].modelo = "GT";
            carros[2].ano = 2018;
            carros[2].velocidadeAtual = 0;
            carros[2].Informacoes();
            carros[2].Acelerar(60);
            carros[2].Informacoes();

        }
    }

}
