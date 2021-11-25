﻿using et12.edu.ar.MenuesConsola;
using SoftwareFactory.Core;
using System;
using System.Collections.Generic;

namespace SoftwareFactory.GUI.Menu
{
    public class MenuListaTecnologia : MenuListador<Tecnologia>
    {
        public MenuListaTecnologia(string nombre)
        {
            Nombre = nombre;
        }
            
        public override void imprimirElemento(Tecnologia elemento)
            => Console.WriteLine($"- tecnologia: {elemento.tecnologia} --costo base: ${elemento.costoBase} -");

        public override List<Cliente> obtenerLista() => Program.Ado.ObtenerClientes();
    }
}
