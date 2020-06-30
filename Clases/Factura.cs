using System.Globalization;
namespace Simulacion_Comercial.Clases
{
    public class Factura : GeneradorAutomaticoIdentificacion
    {
        //constructor
        public Factura() : base()
        {}
        //atributos
        public Cliente Cliente { get; set; }
        public string Detalle { get; set; }
        public float Valor { get; set; }

        //metodos
        public float Sumar()
        {
            return Cliente.Compras = Cliente.Compras + Valor;
        }
    }
}