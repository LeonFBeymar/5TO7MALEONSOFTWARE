using System;

namespace SoftwareFactory.Core
{
    public class Tarea
    {
        public int Id {get; set;}
        public Empleado empleado;
        public DateTime inicio {get; set;}
        public DateTime fin {get; set;}
        public Requerimiento requerimiento;
    
    public Tarea()
    {

    }
    
    public Tarea(DateTime Inicio, DateTime Fin)
    {
        this.inicio = Inicio;
        this.fin = Fin;
        empleado = new Empleado();
        requerimiento = new Requerimiento();
    }
    }
}