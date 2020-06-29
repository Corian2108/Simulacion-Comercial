namespace Simulacion_Comercial.Clases
{
    public class Cliente
    {
        //atributos
        public int Id { get; set; }
        public string Nombres { get; set; }
        public int Compras { get; set; }
        private bool Premium { get; set; }

        Vendedor elVendedor;
        public Vendedor MiVendedor
        {
            get
            {
                return elVendedor;
            }

            set
            {
                elVendedor = value;
                elVendedor.Cliente = this;
            }
        }

        Factura laFactura;
        public Factura MiFactura
        {
            get
            {
                return laFactura;
            }

            set
            {
                laFactura = value;
                laFactura.Cliente = this;
            }
        }
        //metodos
        public string Saludar()
        {
            return $"Hola me llamo {Nombres}. " + 
            elVendedor.Saludar(Nombres);
        }
        public string Comprar(string producto, Productos lavadora, Productos refrigeradora)
        {
            if (producto == "Lavadora")
            {
                //script de lavadora
                return $"Señor {elVendedor.Nombre} necesito comprar una {producto}. " + 
                elVendedor.OfreceProducto(lavadora);

            }
            else if (producto == "Refrigeradora")
            {
                //script refrigeradora
                return $"Señor {elVendedor.Nombre} necesito comprar una {producto}. " + 
                elVendedor.OfreceProducto(refrigeradora);
            }
            else
            {
                return $"Escriba bien";
            }

        }
        public string Desicion(string eleccion)
        {
            if (eleccion == "Si")
            {
                return elVendedor.CerrarVenta(Nombres);
            }
            else if (eleccion == "No")
            {
                return elVendedor.Despedirse(Nombres);
            }
            else
            {
                return $"Escriba bien";
            }
        }
        public string MejorarCategoria()
        {
            if(Compras >= 10000)
            {
                return elVendedor.Notificar();
            }
            else
            {
                return elVendedor.Despedirse(Nombres);
            }
        }
    }
}

/*Tienes que hacer una simulación de un cliente, un vendedor, un electrodomestico y una factura
el cliente le compra al vendedor el electrodomestico y al hacer el pago alcanza la cuota de 1000$ 
haciendose cliente premium se entera por una notificación de la factura*/