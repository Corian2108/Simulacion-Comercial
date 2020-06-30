using System;
namespace Simulacion_Comercial.Clases
{
    public class GeneradorAutomaticoIdentificacion
    {
        readonly Random random = new Random();
        public int Id { get; set; }
        //Constructor
        public GeneradorAutomaticoIdentificacion()
        {
            Id = random.Next();
        }
        public GeneradorAutomaticoIdentificacion(int identificador)
        {
            Id = identificador;
        }
        public GeneradorAutomaticoIdentificacion(string id)
        {
            Id = Convert.ToInt32(id);
        }
    }
}