using System.Collections.Generic;
namespace SoftwareFactory.Core
{
    public class Cliente
    {
        public int Cuit {get; set;}
        public string RazonSocial { get; set;}
        public List<Proyecto> proyecto;

    public Cliente(){ }

        public Cliente(int cuit) => Cuit = cuit;
        public Cliente(string razonSocial) => RazonSocial = razonSocial;
        
    }
}