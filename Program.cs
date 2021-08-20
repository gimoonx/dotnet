using System;  //para poder utilzar o sistema

namespace C_  //pasta onde ta o programa
{
    class Program //começo do programa
    {
        static void Main(string[] args)  //função principal que vai ser desenvolvida
        {

            dynamic cor = "vermelho";
            Console.WriteLine(cor);
            cor = 9827489327;
            Console.WriteLine(cor);
            cor = 3048238047208;
            Console.WriteLine(cor);
            cor = "azul";
            Console.WriteLine(cor);
        }
    } //final do programa
}

            /*
            int segundaGuerraMundial = 1942;
            string cor_Favorita = "vermelho";
            float velocidadeF1 = 294.48f;
            //bool segundaGuerraMundialAconteceu = true;


            Console.WriteLine("Hello World!");
            Console.WriteLine("Meu nome é Giovanna");


            velocidadeF1 = 348.29f;
            //c# reconhece a variável e modifica
            cor_Favorita = "Roxo";

            Console.WriteLine(velocidadeF1);
            Console.WriteLine(cor_Favorita);
            */


//linguagem fortemente tipada = baseado em tipos (diminui a chance de erros, int float, string etc)
//variável dynamic pode alterar a variável para qqlr outro tipo (int, float, string, etc)
//em nome de variáveis n pode ter espaço, caracter especial (tirando _) e o nome da variavel n pode começa com numero

//é possível fazer operações como + - / * :
// Int = para numeros inteiros positivos e negativos
// Float = pode ser numero inteiro positivo e negativo e numero decimal e double
// curiosidade! se chama float devido o ponto mudar de lugar "ponto flutuante"
// bool (booleano) = true or false
// string = "alo aeiou" (um texto/frase)
// char = é apenas um caracter


//var meuTexto = "Hello World - Giovanna - Feliz Natal!";
//Console.ReadLine(); = mantém o cmd aberto (porém vou usar terminal)
//dotnet run = roda o codigo que está no arquivo
//cd desktop = vai para o desktop
//cd = procura pasta ou vai onde vc queira
//dotnet new console = cria um novo arquivo na pasta do projeto escolhida
// IMPORTANTE: sempre cria a pasta primeiro antes de cria o projeto, e procurá-la no terminal criando um new console
// \n = quebra uma linha (pula linha)
// no c# existe uma função pra isso acima para nao colocar sempre \n 
//que é o writeline (já adicionado acima)