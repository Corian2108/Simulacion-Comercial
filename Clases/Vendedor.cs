namespace Simulacion_Comercial.Clases
{
    public class Vendedor : GeneradorAutomaticoIdentificacion
    {
        //constructor
        public Vendedor() : base()
        { }
        //Atributos
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public Cliente Cliente { get; set; }
        //Metodos
        public string Saludar(string nombre)
        {
            return
            $"Hola {nombre}, Binevenido a almacenes la Ganga me llamo {Nombre}, vendedor {Categoria}, ¿En qué te puedo ayudar?; Por el momento solo tenemos disponibles Lavadoras y Refrigeradoras. Escriba Lavadora o Refrigeradora para continuar";
        }
        public string OfreceProducto(Productos Producto)
        {
            return $"Tenemos disponible esta {Producto.Tipo}, marca {Producto.Marca}, modelo {Producto.Modelo}, a un costo de {Producto.Precio}, ¿Desea comprarla?. Si/No";
        }
        public string CerrarVenta(string nombre)
        {
            return $"Perfecto señor {nombre} permitame su numero de cedula, para hacer la factura";

        }
        public string Despedirse(string nombre)
        {
            return $"A sido un gusto atenderle señor {nombre}, Vuelva pronto";
        }
        //Estos datos los pasa factura
        public string Notificar()
        {
            return $"Felicidades Sr.{Cliente.Nombres}, gracais a su compra ahora es cliente Premium y se has ganado un descuento de 150$ en su proxima compra";
        }
    }
}