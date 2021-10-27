namespace SoftwareFactory.Core
{
    public class Tecnologia
    {
        public int id {get; set;}
        public string tecnologia {get; set;}
        public decimal costoBase {get; set;}
    public Tecnologia(int Id, string Tcnologia, decimal Costobase)
    {
        this.id = Id;
        this.tecnologia = Tcnologia;
        this.costoBase = Costobase;
    }
        

    }
}