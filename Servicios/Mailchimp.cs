using Simulacion_Comercial.Interfaces;

namespace Simulacion_Comercial.Servicios
{
    public class Mailchimp: IEmailService
    {
        public string Send()
        {
            return $"Factura Enviada Correctamente";
        }
    }
}