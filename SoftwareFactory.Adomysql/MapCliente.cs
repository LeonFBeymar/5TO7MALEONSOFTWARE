using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using et12.edu.ar.AGBD.Mapeadores;

namespace SoftwareFactory.Adomysql
{
    public class MapCliente : Mapeador<MapCliente>
    {
        public override MapCliente ObjetoDesdeFila(DataRow fila)
        {
            throw new NotImplementedException();
        }
    }
}
