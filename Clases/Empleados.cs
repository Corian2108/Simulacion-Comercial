namespace Simulacion_Comercial.Clases
{
    public abstract class Empleados
    {
        //Atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        //Metodos
        public string Saludar(string nombre)
        {
            return
            $"Saludos Estimado {nombre}, Bienvenido a almacenes la Ganga";
        }
    }
}