using System;

namespace POO_Estatica.obj
{
    public class Conversor
    {
        public static float cotacaoDolar = 5.10f;

        public static float valorUsuario;

        public static float ConverterDolarParaReal(float valorEmDolar){
            return valorUsuario * cotacaoDolar;
        }

        public static float ConverterRealParaDolar(float valorEmReal){
            return valorUsuario / cotacaoDolar; 
        }

        internal static float ConverterDolarParaReal()
        {
            throw new NotImplementedException();
        }

        internal static float ConverterRealParaDolar()
        {
            throw new NotImplementedException();
        }
    }
}