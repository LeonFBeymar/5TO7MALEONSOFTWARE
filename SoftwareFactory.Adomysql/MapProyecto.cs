using et12.edu.ar.AGBD.Ado;
using et12.edu.ar.AGBD.Mapeadores;
using SoftwareFactory.Core;
using System;
using System.Data;
using System.Collections.Generic;

namespace SoftwareFactory.Adomysql
{
    class MapProyecto : Mapeador<Proyecto>
    {
        public MapProyecto(AdoAGBD ado) : base(ado)
        {
            Tabla = "Proyecto";
        }
        public override Proyecto ObjetoDesdeFila(DataRow fila)

             => new Proyecto()
             {
                 Id = Convert.ToByte(fila["idRubro"]),
                 descripcion = fila["descripcion"].ToString(),
                 presupuesto = Convert.ToDouble(fila["descripcion"]),
                 inicio = Convert.ToDateTime(fila["descripcion"]),
                 fin = Convert.ToDateTime(fila["descripcion"])
             };


    }
}
