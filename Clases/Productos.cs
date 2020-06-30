namespace Simulacion_Comercial.Clases
{
    public class Productos : GeneradorAutomaticoIdentificacion
    {
        //constructor
        public Productos() : base()
        {}
        //atributos
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; } //float porque tiene decimales
        //metodos
        public string Encender(){
            return $"Ruidos de encendido";
        }
        public string Usar(){
            return $"Ruidos motor funcionando";
        }
        public string Apagar(){
            return $"apagado";
        }
        public string Daño(){
            return $"Me dañé llame a servicio técnico";
        }
    }
}