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