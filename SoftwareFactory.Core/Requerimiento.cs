namespace SoftwareFactory.Core
{
    public class Requerimiento
    {
        public int id {get; set;}
        Proyecto proyecto = new Proyecto();
        Tecnologia tecnologia = new Tecnologia();
        public string descripcion {get; set;}
        public ushort complejidad {get; set;}
    }
}