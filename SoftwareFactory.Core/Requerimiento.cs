namespace SoftwareFactory.Core
{
    public class Requerimiento
    {
        public int Id {get; set;}
        public Proyecto proyecto;
        public Tecnologia tecnologia;
        public string descripcion {get; set;}
        public ushort complejidad {get; set;}
    
    public Requerimiento()
    {

    }
    
    public Requerimiento(string Descripcion, ushort Complejidad) 
    {
        this.descripcion = Descripcion;
        this.complejidad = Complejidad;
        proyecto = new Proyecto();
        tecnologia = new Tecnologia();
    }
    }
}