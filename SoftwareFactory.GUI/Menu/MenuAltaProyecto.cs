using et12.edu.ar.MenuesConsola;
using SoftwareFactory.Core;
using System;


namespace SoftwareFactory.GUI.Menu
{
    public class MenuAltaProyecto : MenuComponente
    {
        
        public Proyecto Proyecto { get; private set; }
        private MenuListaCliente menuListaClientes { get;  set; }

        public MenuAltaProyecto(string Nombre): base(Nombre)
        {
        }
        public MenuAltaProyecto() :this("Alta Proyecto") { }

        public override void mostrar()
        {
            base.mostrar();

            var id = int.Parse(prompt("ingrese id: "));
            var descripcion = prompt("ingrese Descripcion");
            var presupuesto = double.Parse(prompt("ingrese Presupuesto"));
            var inicio = DateTime.Parse(prompt("ingrese fecha de inicio el Proyecto"));
            var fin = DateTime.Parse(prompt("ingrese fecha de finalizado el Proyecto"));
            Console.WriteLine("Seleccionar un Ciut: ");
            var Cliente = menuListaClientes.seleccionarElemento();

            Proyecto = new Proyecto()
            {
                idProyecto = id,
                descripcion = descripcion,
                presupuesto = presupuesto,
                inicio = inicio,
                fin = fin,
                cliente = Cliente

            };
            Program.Ado.AltaProyecto(Proyecto);
        }
    }
}
