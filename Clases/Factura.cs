using System.Globalization;
namespace Simulacion_Comercial.Clases
{
    public class Factura
    {
        //atributos
        public Cliente Cliente { get; set; }
        public int Id { get; set; }
        public string Detalle { get; set; }
        public int Valor { get; set; }

        //metodos
        public int Sumar()
        {
            return Cliente.Compras = Cliente.Compras + Valor;
        }
    }
}