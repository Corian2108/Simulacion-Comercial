﻿using System;
using Simulacion_Comercial.Clases;

namespace Simulacion_Comercial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reemplaza los id de cada clase haciendolas clases hijas
            var Empresa = new Empresa();
            var bicicleta = new Bicicleta
            {
                Marca = "GT",
                Modelo = "Karakoram",
                Precio = 900
            };
            
            //Instanciar productos lavadora y refrigeradora
            Productos lavadora = new Productos
            {
                Tipo = "Lavadora",
                Marca = "Mabe",
                Modelo = "Super Wash",
                Precio = 1200
            };

             Productos refrigeradora = new Productos
            {
                Tipo = "Refrigeradora",
                Marca = "Indurama",
                Modelo = "Side by Side 566L",
                Precio = 2200
            };
            //Instanciar vendedor
             Vendedor vendedor1 = new Vendedor
             {
                Nombre = "Carlos",
                Categoria = "Junior",
             };
            //Solicita introducir Nombre
            Console.WriteLine("Para iniciar introduce tu nombre");
            string nombreCliente = Console.ReadLine();
            //Isntancia Cliente con nombre introducido y asiga id aleatorio
             Cliente cliente1 = new Cliente
             {
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
                    Detalle = $"{lavadora.Tipo} {lavadora.Marca} {lavadora.Modelo}",
                    Valor = lavadora.Precio
                };
                cliente1.MiFactura = factura1;
                Console.WriteLine($"Felicidades Sr.{cliente1.Nombres}, a acumulado {factura1.Sumar()} en nuestro programa de fidelizacion");
                Console.WriteLine(cliente1.MejorarCategoria());
            }
            else if (opcion == "Refrigeradora")
            {
                Factura factura1 = new Factura
                {
                    Cliente = cliente1,
                    Detalle = $"{refrigeradora.Tipo} {refrigeradora.Marca} {refrigeradora.Modelo}",
                    Valor = refrigeradora.Precio
                };
                cliente1.MiFactura = factura1;
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
