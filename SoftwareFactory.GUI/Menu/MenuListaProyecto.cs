using et12.edu.ar.MenuesConsola;
using SoftwareFactory.Core;
using System;
using System.Collections.Generic;

namespace SoftwareFactory.GUI.Menu
{
    class MenuListaProyecto : MenuListador<Proyecto>
    {
        public MenuListaProyecto(string nombre)
        {
            Nombre = nombre;
        }

        public override void imprimirElemento(Proyecto elemento)
        {
            string fin = elemento.fin.HasValue ? elemento.fin.Value.ToShortDateString() : "En Proceso";
            Console.WriteLine($" Decripcion: {elemento.descripcion}\n Presupuesto: ${elemento.presupuesto}\t Inicio: {elemento.inicio.ToShortDateString()} Fin: {fin}\t Cliente: {elemento.cliente.Cuit} -");
        }

        public override List<Proyecto> obtenerLista() => Program.Ado.ObtenerProyectos();
    }
}
