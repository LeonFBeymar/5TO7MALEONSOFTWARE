namespace SoftwareFactory.Core
{
    public class Proyecto
    {
        public int id {get; set;}
        public Cliente cliente = new Cliente();
        public string descripcion {get; set;}
        public double presupuesto {get; set;}
        public DateTime inicio {get; set;}
        public DateTime fin {get; set;}
        public List<Requerimiento> requerimientos = new List<Requerimiento>(); 
    }
}