using et12.edu.ar.MenuesConsola;
using SoftwareFactory.Core;
using System;


namespace SoftwareFactory.GUI.Menu
{
    public class MenuAltaProyecto : MenuComponente
    {
        
        public Proyecto Proyecto { get; private set; }
        private MenuListaCliente MenuListaClientes { get;  set; }

        public MenuAltaProyecto() :base("Alta Proyecto") { }

        public MenuAltaProyecto(MenuListaCliente listaCliente) : this()
        {
            MenuListaClientes = listaCliente;
        }

        public override void mostrar()
        {
            base.mostrar();

            var descripcion = prompt("ingrese Descripcion");
            var presupuesto = double.Parse(prompt("ingrese Presupuesto"));
            var inicio = DateTime.Parse(prompt("ingrese fecha de inicio el Proyecto"));
            var fin = DateTime.Parse(prompt("ingrese fecha de finalizado el Proyecto"));
            Console.WriteLine("Seleccionar valor x) ");
            var Cliente = MenuListaClientes.seleccionarElemento();

            Proyecto = new Proyecto()
            {               
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
