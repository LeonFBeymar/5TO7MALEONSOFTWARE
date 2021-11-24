using et12.edu.ar.MenuesConsola;
using SoftwareFactory.Core;
using System;
using System.Collections.Generic;

namespace SoftwareFactory.GUI.Menu
{
    public class MenuListaCliente : MenuListador<Cliente>
    {
        public override void imprimirElemento(Cliente elemento)
            => Console.WriteLine($"{elemento.RazonSocial} -- {elemento.Cuit} ");

        public override List<Cliente> obtenerLista() => Program.Ado.ObtenerClientes();
    }
}
