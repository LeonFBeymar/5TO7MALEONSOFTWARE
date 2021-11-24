using System;
using System.Collections.Generic;
using SoftwareFactory.Core;
using et12.edu.ar.AGBD.Ado;

namespace SoftwareFactory.Adomysql
{
    public class AdoMySql : IAdo
    {
        public AdoAGBD Ado { get; set; }

        public MapCliente MapCliente { get; set; }

        public MapProyecto MapProyecto { get; set; }

        public AdoMySql(AdoAGBD ado)
        {
            Ado = ado;
            MapCliente = new MapCliente(ado);
            MapProyecto = new MapProyecto(MapCliente);
        }
        public void AltaCliente(Cliente cliente) => MapCliente.AltaCliente(cliente);

        public List<Cliente> ObtenerClientes() => MapCliente.ObtenerClientes();

        public void AltaProyecto(Proyecto proyecto) => MapProyecto.AltaProyecto(proyecto);

        public List<Proyecto> ObtenerProyectos() => MapProyecto.ObtenerProyecto();

    }
}


        
