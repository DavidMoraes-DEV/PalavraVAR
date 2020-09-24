using System;

namespace PalavraVAR
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/
            int x = 10;
            var y = 15; /*A pavra VAR é utilizada para declarar uma variável normal, porém ela possibilita
            que não seja preciso declarar o tipo da variável(int, double, string), pois sendo uma variável
            com a palavra var seu tipo será INFERIDO(percebido) conforme for iniciado a variável. No exemplo
            da variavel y o próprio compilador indentifica pelo valor dela"15" que ela é do tipo int(inteiro)
            então nesse momento a variável y esta sendo do tipo int*/

            var z = 10.0; /*Aqui o compilador entende que como o valor é quebrado(com casas decimais) seu tipo
            passará a ser double*/

            var n = "Maria"; /*E aqui o compilador entenderá que apartir desse contexto seu tipo é string e assim por diante*/
        }
    }
}
