using System;

namespace POO_Estatica
{
    class Program
    {
        static void Main(string[] args)
        {

            // Classes estáticas não podem ser instanciadas

            // Em que momento usamos classes estáticas?
            // R: Quando precisarmos de uma solução que pode servir para qualquer tipo de aplicação

            // Em que momento não usamos classes estáticas?
            // R: Quando tivermos objetos/classes que são específicas de um tipo de aplicação

            Console.WriteLine( Math.Pow(2, 5) );
            // acima exemplo de potenciação. // primeiro número é ele próprio, e o segundo é expoente

            Console.WriteLine("Digite um valor: ");
            obj.Conversor.valorUsuario = float.Parse( Console.ReadLine() );

           Console.WriteLine(  obj.Conversor.ConverterDolarParaReal() );

           Console.WriteLine(  obj.Conversor.ConverterRealParaDolar() );

            // Este método também tem quer ser static na sua declaração
            Testar();
            


        } // fim do Main

        static void Testar(){

        }
    }
}
