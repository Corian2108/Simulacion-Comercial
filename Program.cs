using System;
using Simulacion_Comercial.Clases;
using Simulacion_Comercial.Models;
using Simulacion_Comercial.Servicios;

namespace Simulacion_Comercial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar productos lavadora y refrigeradora
            Random generador = new Random();
            int id = generador.Next();
            
            Productos lavadora = new Productos
            {
                Id = id,
                Tipo = "Lavadora",
                Marca = "Mabe",
                Modelo = "Super Wash",
                Precio = 1200
            };

             Productos refrigeradora = new Productos
            {
                Id = id,
                Tipo = "Refrigeradora",
                Marca = "Indurama",
                Modelo = "Side by Side 566L",
                Precio = 2200
            };
            //Instanciar vendedor
             Vendedor vendedor1 = new Vendedor
             {
                 Id = id,
                 Nombre = "Carlos",
                 Categoria = "Junior",
             };
            //Solicita introducir Nombre
            Console.WriteLine("Para iniciar introduce tu nombre");
            string nombreCliente = Console.ReadLine();
            //Isntancia Cliente con nombre introducido y asiga id aleatorio
             Cliente cliente1 = new Cliente
             {
                 Id = id,
                 Nombres = nombreCliente,
                 Compras = 8000,
                 MiVendedor = vendedor1
             };

            //Cliente.Saludar
            Console.WriteLine(cliente1.Saludar());
            //Vendedor.Saludar
            string opcion = Console.ReadLine();
            Console.WriteLine(cliente1.Comprar(opcion, lavadora, refrigeradora));
            //Desicion de compra
            string desicion = Console.ReadLine();
            Console.WriteLine(cliente1.Desicion(desicion));
            //Cambiar id
            string cedulaString = Console.ReadLine();
            int cedula = Convert.ToInt32(cedulaString);
            cliente1.Id = cedula;
            //Instanciar factura
            if (opcion == "Lavadora")
            {
                Factura factura1 = new Factura
                {
                    Cliente = cliente1,
                    Id = id,
                    Detalle = $"{lavadora.Tipo} {lavadora.Marca} {lavadora.Modelo}",
                    Valor = lavadora.Precio
                };
                //Instanciamiento de EmailService
                var Email1 = new Mailchimp();
                cliente1.MiFactura = factura1;
                //Envio de Factura
                Console.WriteLine(Email1.Send());
                Console.WriteLine($"Felicidades Sr.{cliente1.Nombres}, a acumulado {factura1.Sumar()} en nuestro programa de fidelizacion");
                Console.WriteLine(cliente1.MejorarCategoria());
            }
            else if (opcion == "Refrigeradora")
            {
                Factura factura1 = new Factura
                {
                    Cliente = cliente1,
                    Id = id,
                    Detalle = $"{refrigeradora.Tipo} {refrigeradora.Marca} {refrigeradora.Modelo}",
                    Valor = refrigeradora.Precio
                };
                //Instanciamiento de EmailService
                var Email1 = new SendGrid();
                cliente1.MiFactura = factura1;
                //Envio de Factura
                Console.WriteLine(Email1.Send());
                Console.WriteLine($"Felicidades Sr.{cliente1.Nombres}, a acumulado {factura1.Sumar()} en nuestro programa de fidelizacion");
                Console.WriteLine(cliente1.MejorarCategoria());
            }
            else
            {
                Console.WriteLine("Escriba bien");
            }
        }
    }
}
