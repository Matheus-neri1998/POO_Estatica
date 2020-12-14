using System;

namespace POO_Estatica.obj
{
    public class Conversor
    {
        public static float cotacaoDolar = 5.10f;

        public static float cotacaoEuro = 6.21f;

        public static float valorUsuario;

        public static float valorUsername;

        public static float ConverterDolarParaReal(float valorEmDolar){
            return valorUsuario * cotacaoDolar;
        }

        public static float ConverterRealParaDolar(float valorEmReal){
            return valorUsuario / cotacaoDolar; 
        }

        public static float ConverterEuroParaReal(float valorEmEuro){
            return valorUsername * cotacaoEuro;
        }
        public static float ConverterRealParaEuro(float valorEmReal){
            return valorUsername / cotacaoEuro;
        }


        internal static float ConverterDolarParaReal()
        {
            throw new NotImplementedException();
        }

        internal static float ConverterRealParaDolar()
        {
            throw new NotImplementedException();
        }

        internal static float ConverterEuroParaReal()
        {
            throw new NotImplementedException();
        }

        internal static float ConverterRealParaEuro()
        {
            throw new NotImplementedException();
        }
    }
}