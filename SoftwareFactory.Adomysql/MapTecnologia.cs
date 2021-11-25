using et12.edu.ar.AGBD.Ado;
using et12.edu.ar.AGBD.Mapeadores;
using System;
using System.Data;
using System.Collections.Generic;
using SoftwareFactory.Core;

namespace SoftwareFactory.Adomysql
{
    public class MapTecnologia : Mapeador<Tecnologia>
    {
        public MapTecnologia(AdoAGBD ado) : base(ado)
        {
            Tabla = "Tecnologia";
        }

        public override Tecnologia ObjetoDesdeFila(DataRow fila)
         => new Tecnologia()
         {
             IdTecnologia = Convert.ToInt32(fila["IdTecnologia"]),
             tecnologia = fila["tecnologia"].ToString(),
             costoBase = Convert.ToDecimal(fila["CostoBase"])
         
         };

        public void AltaTecnologia(Tecnologia tecnologia)
            => EjecutarComandoCon("altaTecnologia", ConfigurarAltaTecnologia, PostAltaTecnologia, tecnologia);
        public void ConfigurarAltaTecnologia(Tecnologia tecnologia)
        {

            SetComandoSP("AltaTecnologia");

            BP.CrearParametro("unidTecnologia")
              .SetTipo(MySql.Data.MySqlClient.MySqlDbType.Int32)
              .AgregarParametro();

            BP.CrearParametro("unaTecnologia")
              .SetTipoVarchar(20)
              .SetValor(tecnologia.tecnologia)
              .AgregarParametro();

            BP.CrearParametro("unCostoBase")
              .SetTipoDecimal(10, 2)
              .SetValor(tecnologia.costoBase)
              .AgregarParametro();

        }
        
        public void PostAltaTecnologia(Tecnologia tecnologia)
            => tecnologia.IdTecnologia = Convert.ToInt32(GetParametro("unidTecnologia").Value);

        public List<Tecnologia> ObtenerTecnologia() => ColeccionDesdeTabla();
    }
}
