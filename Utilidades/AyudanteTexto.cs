using System;

namespace Simulacion_Comercial.Utilidades
{
    public static class AyudanteTexto
    {
        //Propiedades
        public static string DividirTexto( string texto)
        {
            var dividido = texto.Split(",");
            foreach (var palabra in dividido)
            {
                Console.Write(palabra);
            }
            return " ¡¡Dividido Correctamente!!";
        }
    }
}