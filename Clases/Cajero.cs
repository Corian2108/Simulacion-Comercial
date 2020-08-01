namespace Simulacion_Comercial.Clases
{
    public class Cajero: Empleados
    {
        //Atributos
        public Cliente Cliente { get; set;}
        //Metodos
        public string HacerFactura(string nombre)
        {
            return $"Señor {nombre} permitame su cédula de identidad para hacer su factura";
        }
    }
}