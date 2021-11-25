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
    public Tecnologia(string Tecnologia, decimal Costobase)
    {
        this.tecnologia = Tecnologia;
        this.costoBase = Costobase;
    }
        

    }
}