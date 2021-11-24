using et12.edu.ar.MenuesConsola;
using SoftwareFactory.Core;
using System;
using System.Collections.Generic;

namespace SoftwareFactory.GUI.Menu
{
    class MenuListaProyecto : MenuListador<Proyecto>
    {
        public override void imprimirElemento(Proyecto elemento)
            => Console.WriteLine($"{elemento.idProyecto} -- {elemento.descripcion} -- {elemento.presupuesto} -- {elemento.inicio} -- {elemento.fin} -- {elemento.cliente.Cuit}");

        public override List<Proyecto> obtenerLista() => Program.Ado.ObtenerProyectos();
    }
}
