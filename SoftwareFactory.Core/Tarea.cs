namespace SoftwareFactory.Core
{
    public class Tarea
    {
        public int id {get; set;}
        public Empleado empleado = new Empleado();
        public DateTime inicio {get; set;}
        public DateTime fin {get; set;}
        public Requerimiento requerimiento = new Requerimiento();
    }
}