using et12.edu.ar.MenuesConsola;
using SoftwareFactory.Core;
using System;
using System.Collections.Generic;

namespace SoftwareFactory.GUI.Menu
{
    public class MenuListaCliente : MenuListador<Cliente>
    {
        public MenuListaCliente(string nombre)
        {
            Nombre = nombre;
        }
        public override void imprimirElemento(Cliente elemento)
            => Console.WriteLine($" Razon Social: {elemento.RazonSocial}\t Cuit: {elemento.Cuit} -");

        public override List<Cliente> obtenerLista() => Program.Ado.ObtenerClientes();
    }
}
