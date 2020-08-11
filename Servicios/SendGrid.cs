using Simulacion_Comercial.Interfaces;

namespace Simulacion_Comercial.Servicios
{
    public class SendGrid: IEmailService
    {
        public string Send()
        {
            return $"Su Factura ha sido enviada con éxito";
        }
    }
}