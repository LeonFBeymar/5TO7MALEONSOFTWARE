using et12.edu.ar.AGBD.Mapeadores;
using SoftwareFactory.Core;
using System;
using System.Data;

namespace SoftwareFactory.Adomysql
{
    class MapProyecto : Mapeador<Proyecto>
    {
        public override Proyecto ObjetoDesdeFila(DataRow fila)
        {
            throw new NotImplementedException();
        }
    }
}
