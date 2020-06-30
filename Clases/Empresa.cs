using System;
namespace Simulacion_Comercial.Clases
{
    public class Empresa : GeneradorAutomaticoIdentificacion
    {
        //atributos
        public string Nombre { get; set; }
        public Empresa() : base()
        {  }
        /*public Empresa() : base()
        { Para usar sobrecarga? }*/
    }
}