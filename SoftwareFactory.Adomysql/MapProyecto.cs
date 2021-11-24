using et12.edu.ar.AGBD.Ado;
using et12.edu.ar.AGBD.Mapeadores;
using SoftwareFactory.Core;
using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace SoftwareFactory.Adomysql
{
    public class MapProyecto : Mapeador<Proyecto>
    {
        public MapCliente Mapcliente { get; set; }

        public MapProyecto(AdoAGBD ado) : base(ado)
        {
            Tabla = "Proyecto";
        }
        public override Proyecto ObjetoDesdeFila(DataRow fila)
            => new Proyecto()
            {
            
                Id = Convert.ToInt32(fila["id"]),
                descripcion = fila["descripcion"].ToString(),
                cliente = Mapcliente.ClientePorCuit(Convert.ToInt32(fila["Cuit"])),
                presupuesto = Convert.ToDouble(fila["presupuesto"]),
                inicio = Convert.ToDateTime(fila["inicio"]),
                fin = Convert.ToDateTime(fila["fin"]),
            };
        public List<Proyecto> ObtenerProyecto() => ColeccionDesdeTabla();
        public List<Proyecto> ObtenerProyecto(Cliente cliente)
        {
            SetComandoSP("ProyectosPorCliente");

            BP.CrearParametro("unCuit")
              .SetTipo(MySql.Data.MySqlClient.MySqlDbType.Int32)
              .SetValor(cliente.Cuit)
              .AgregarParametro();

            return ColeccionDesdeSP();
        }
        public void AltaProyecto(Proyecto proyecto)
           => EjecutarComandoCon("altaRubro", ConfigurarAltaProyecto, proyecto);

        private void ConfigurarAltaProyecto(Proyecto proyecto)
        {
            SetComandoSP("altaProyecto");

            BP.CrearParametroSalida("unIdProyceto")
              .SetTipo(MySql.Data.MySqlClient.MySqlDbType.Int32)
              .AgregarParametro();

            BP.CrearParametro("unCuit")
             .SetTipo(MySql.Data.MySqlClient.MySqlDbType.Int32)
             .SetValor(proyecto.cliente.Cuit)
             .AgregarParametro();

            BP.CrearParametro("unPresupuesto")
              .SetTipo(MySql.Data.MySqlClient.MySqlDbType.Double)
              .SetValor(proyecto.descripcion)
              .AgregarParametro();

            BP.CrearParametro("unInicio")
              .SetTipo(MySql.Data.MySqlClient.MySqlDbType.DateTime)
              .SetValor(proyecto.inicio)
              .AgregarParametro();

            BP.CrearParametro("unFin")
              .SetTipo(MySql.Data.MySqlClient.MySqlDbType.DateTime)
              .SetValor(proyecto.fin)
              .AgregarParametro();
        }
    }
}

       
