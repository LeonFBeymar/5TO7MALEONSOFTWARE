using et12.edu.ar.MenuesConsola;
using SoftwareFactory.Core;
using System;

namespace SoftwareFactory.GUI.Menu
{
    public class MenuAltaCliente : MenuComponente
    {
        public  Cliente Cliente { get; set; }

        public MenuAltaCliente(string nombre) : base(nombre)
        {
        }

        public MenuAltaCliente() : this("Alta Cliente") { }

        public override void mostrar()
        {
            base.mostrar();

            var razonSocial = prompt("Ingrese razon social: ");
            int cuit = Convert.ToInt32(prompt("Ingrese cuit"));

            Cliente = new Cliente()
            {
                RazonSocial = razonSocial,
                Cuit = cuit
            };

            Program.Ado.AltaCliente(Cliente);
        }
    }
}
