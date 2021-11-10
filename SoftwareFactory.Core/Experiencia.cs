namespace SoftwareFactory.Core
{
    public class Experiencia
    {
        public Empleado empleado;
        public Tecnologia tecnologia;
        public ushort calificacion {get; set;}
    
    public Experiencia()
    {
        
    }
    
    public Experiencia(ushort Calificacion)
    {
        this.calificacion = Calificacion;
        empleado = new Empleado();
        tecnologia = new Tecnologia();
    }
    }
}