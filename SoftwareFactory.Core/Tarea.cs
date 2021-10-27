namespace SoftwareFactory.Core
{
    public class Tarea
    {
        public int id {get; set;}
        public Empleado empleado = new Empleado();
        public DateTime inicio {get; set;}
        public DateTime fin {get; set;}
        public Requerimiento requerimiento = new Requerimiento();
    
    public Tarea(int Id, DateTime Inicio, DateTime Fin)
    {
        this.id = Id;
        this.inicio = Inicio;
        this.fin = Fin;
        empleado = new Empleado();
        requerimiento = new Requerimiento();
    }
    }
}