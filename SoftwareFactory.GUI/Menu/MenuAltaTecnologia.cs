using et12.edu.ar.MenuesConsola;
using SoftwareFactory.Core;
using System;

namespace SoftwareFactory.GUI.Menu
{
    class MenuAltaTecnologia : MenuComponente
    {
        public Tecnologia Tecnologia { get; set; }

        public MenuAltaTecnologia(string nombre) : base(nombre)
        {
        }

        public MenuAltaTecnologia() : this("Alta Tecnologia") { }

        public override void mostrar()
        {
            base.mostrar();

            var tecnologiaE = prompt("Ingrese una tecnologia: ");
            decimal costoBaseA = Convert.ToInt32(prompt("Ingrese el costo base:"));

            Tecnologia = new Tecnologia()
            {
                tecnologia = tecnologiaE,
                costoBase = costoBaseA
            };

            Program.Ado.AltaTecnologia(Tecnologia);
        }
    }
}
