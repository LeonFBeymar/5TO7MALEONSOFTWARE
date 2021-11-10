namespace SoftwareFactory.Core
{
    public class Empleado
    {
        public int cuil {get; set;} 
        public string nombre {get; set;}
        public string apellido {get; set;}
        public DateTime Contratacion {get; set;}

    public Empleado()
    {
        
    }
    
    public Empleado(int Cuil, string Nombre, string Apellido, DateTime contratacion)
    {
        this.cuil = Cuil;
        this.nombre = Nombre;
        this.apellido = Apellido;
        this.Contratacion = contratacion;
    }
    }
}