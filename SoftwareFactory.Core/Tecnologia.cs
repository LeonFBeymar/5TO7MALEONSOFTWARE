namespace SoftwareFactory.Core
{
    public class Tecnologia
    {
        public int IdTecnologia {get; set;}
        public string tecnologia {get; set;}
        public decimal costoBase {get; set;}
    
    public Tecnologia()
    {

    }
    public Tecnologia(string Tcnologia, decimal Costobase)
    {
        this.tecnologia = Tcnologia;
        this.costoBase = Costobase;
    }
        

    }
}