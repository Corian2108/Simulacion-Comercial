using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace Simulacion_Comercial.Clases
{
    public class Factura
    {
        //atributos
        [Key]
        public int Id { get; set; }
        public string Detalle { get; set; }
        public int Valor { get; set; }
        //Foreign Key
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        //metodos
        public int Sumar()
        {
            return Cliente.Compras = Cliente.Compras + Valor;
        }
    }
}