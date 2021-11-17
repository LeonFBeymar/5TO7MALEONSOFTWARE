using System;
using System.Collections.Generic;

namespace SoftwareFactory.Core
{
    public class Proyecto
    {
        public int Id {get; set;}
        public Cliente cliente;
        public string descripcion {get; set;}
        public double presupuesto {get; set;}
        public DateTime inicio {get; set;}
        public DateTime fin {get; set;}
        public List<Requerimiento> requerimientos; 

        public Proyecto()
        {

        }


        public Proyecto(string Descripcion, double Presupuesto, DateTime Inicio, DateTime Fin)
        {
            this.descripcion = Descripcion;
            this.presupuesto = Presupuesto;
            this.inicio = Inicio;
            this.fin = Fin;
            cliente = new Cliente();
            requerimientos = new List<Requerimiento>();
        }
    }
}