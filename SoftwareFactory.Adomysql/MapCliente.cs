using et12.edu.ar.AGBD.Ado;
using et12.edu.ar.AGBD.Mapeadores;
using System;
using System.Data;
using System.Collections.Generic;
using SoftwareFactory.Core;

namespace SoftwareFactory.Adomysql
{
    public class MapCliente : Mapeador<Cliente>
    {
        public MapCliente(AdoAGBD ado) : base(ado)
        {
            Tabla = "Cliente";
        }

        public override Cliente ObjetoDesdeFila(DataRow fila)
            => new Cliente()
            {
                Cuit = Convert.ToInt32(fila["Cuit"]),
                RazonSocial = fila["RazonSocial"].ToString()
                
            };
        public void AltaCliente(Cliente cliente)
            => EjecutarComandoCon("altaCliente", ConfigurarAltaCliente, cliente);
        public void ConfigurarAltaCliente(Cliente cliente)
        {
            SetComandoSP("AltaCliente");

            BP.CrearParametro("unCuit")
            .SetTipo(MySql.Data.MySqlClient.MySqlDbType.Int32)
            .SetValor(cliente.Cuit)
            .AgregarParametro();

            
            
            BP.CrearParametro("unaRazonSocial")
            .SetTipoVarchar(45)
            .SetValor(cliente.RazonSocial)
            .AgregarParametro();     
        }
        public void ObtenerCliente(int cuit)
        {
            SetComandoSP("llamarCliente");

        }
        
        public List<Cliente> ObtenerClientes() => ColeccionDesdeTabla();
    }
}
