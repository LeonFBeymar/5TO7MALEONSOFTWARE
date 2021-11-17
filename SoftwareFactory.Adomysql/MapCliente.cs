using System;
using System.Data;
using et12.edu.ar.AGBD.Mapeadores;
using et12.edu.ar.AGBD.Ado;
using System.Collections.Generic;

namespace SoftwareFactory.Adomysql
{
    public class MapCliente : Mapeador<MapCliente>
    {
        public MapCliente(AdoAGBD ado) : base(ado)
        {
            Tabla = "Cliente";
        }
        public override MapCliente ObjetoDesdeFila(DataRow fila)

        => new MapCliente()
        {
            cuit = Convert.ToByte(fila["idRubro"]),
            Nombre = fila["rubro"].ToString()
        };





    }
}
