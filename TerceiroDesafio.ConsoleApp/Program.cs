using System;

namespace TerceiroDesafio.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtdEspacosMeio = 1, diferencaEntreLetras = -1;
            char letraAtual = 'A', letraUsuario;

            #region Código de captura de entrada e tratamento dos dados do usuário
            Console.Write("Informe uma letra: ");
            letraUsuario = char.ToUpper(Convert.ToChar(Console.ReadLine()));
            #endregion

            Console.WriteLine();

            #region Código que escreve a parte de cima do diamante

            //Lembrando que 65 é o código ASCII do 'A'
            for (int linha = 65; linha < letraUsuario; linha++)
            {
                diferencaEntreLetras = letraUsuario - linha;

                //Definindo a quantidade de espaços iniciais
                for (int espacosIniciais = 0; espacosIniciais < diferencaEntreLetras; espacosIniciais++)
                {
                    Console.Write(' ');
                }

                //Escrevendo a letra
                letraAtual = Convert.ToChar(linha);
                Console.Write(letraAtual);

                if (linha == 65)
                {
                    Console.WriteLine("\n");
                }

                //Definindo a quantidade de espaços do meio
                else
                {
                    for (int espacosMeio = 0; espacosMeio < qtdEspacosMeio; espacosMeio++)
                    {
                        Console.Write(' ');
                    }

                    qtdEspacosMeio += 2;

                    //Escrevendo a letra depois dos espaços do meio
                    letraAtual = Convert.ToChar(linha);
                    Console.WriteLine(letraAtual + "\n");
                }
            }
            #endregion

            #region Código que escreve a parte do meio do diamante
            
            if (diferencaEntreLetras == 1)
            {
                letraAtual = Convert.ToChar(letraAtual + 1);
                Console.Write(letraAtual);
                for (int espacosMeio = 0; espacosMeio < qtdEspacosMeio; espacosMeio++)
                {
                    Console.Write(' ');
                }
                Console.Write(letraAtual);
                Console.WriteLine("\n");
                letraAtual = Convert.ToChar(letraAtual - 1);
            }

            #endregion

            #region Código que escreve a parte de baixo do diamante
            
            //Lembrando que 65 é o código ASCII do 'A'
            for (int linha = letraAtual; linha >= 65; linha--)
            {
                diferencaEntreLetras = letraUsuario - linha;

                //Definindo a quantidade de espaços iniciais
                for (int espacosIniciais = 0; espacosIniciais < diferencaEntreLetras; espacosIniciais++)
                {
                    Console.Write(' ');
                }

                //Escrevendo a letra
                letraAtual = Convert.ToChar(linha);
                Console.Write(letraAtual);
                
                if (linha == 65)
                {
                    Console.WriteLine();
                }
                else
                {
                    //Definindo a quantidade de espaços do meio
                    qtdEspacosMeio -= 2;
                    for (int espacosMeio = 0; espacosMeio < qtdEspacosMeio; espacosMeio++)
                    {
                        Console.Write(' ');
                    }

                    //Escrevendo a letra depois dos espaços do meio
                    letraAtual = Convert.ToChar(linha);
                    Console.WriteLine(letraAtual + "\n");
                }
            }
            #endregion

        }
    }
}
