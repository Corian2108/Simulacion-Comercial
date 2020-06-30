using System;
namespace Simulacion_Comercial.Clases
{
    public class Bicicleta : Productos
    {
        public Bicicleta() : base()
        {
        }
        //atributos
        
        //metodos
        public string Frenar()
        {
            return $"La bicicleta {Id} está frenando";
        }
    }
}