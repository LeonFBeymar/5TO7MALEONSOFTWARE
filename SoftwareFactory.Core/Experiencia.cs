namespace SoftwareFactory.Core
{
    public class Experiencia
    {
        public Empleado empleado = new Empleado();
        public Tecnologia tecnologia = new Tecnologia();
        public ushort calificacion {get; set;}
    
    public Experiencia(int Calificacion)
    {
        this.calificacion = Calificacion;
        empleado = new Empleado();
        tecnologia = new Tecnologia();
    }
    }
}