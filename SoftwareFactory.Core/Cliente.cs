namespace SoftwareFactory.Core
{
    public class Cliente
    {
        public int cuit {get; set;}
        public string RazonSocial { get; set;}
        public List<Proyecto> proyecto = new List<Proyecto>();

    public Cliente(int Cuit, string razonSocial)
    {
        this.cuit = Cuit;
        this.RazonSocial = razonSocial;
        proyecto = new List<Proyecto>();
    }
    }
}