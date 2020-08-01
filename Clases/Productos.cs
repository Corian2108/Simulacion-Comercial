namespace Simulacion_Comercial.Clases
{
    public class Productos
    {
        //atributos
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Precio { get; set; }
        //metodos
        public string Encender()
        {
            return $"Ruidos de encendido";
        }
        public string Encender(int voltaje)
        {
            if (voltaje >= 130)
            {
                return "Si me conectas con mucho voltaje me voy a quemar";
            }
            else
            {
                return "Es el voltaje correcto, pero igual me puedo dañar";
            }
        }
        public string Usar()
        {
            return $"Ruidos motor funcionando";
        }
        public string Apagar()
        {
            return $"apagado";
        }
        public string Daño()
        {
            return $"Me dañé llame a servicio técnico";
        }
    }
}