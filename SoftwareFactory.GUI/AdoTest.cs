using SoftwareFactory.Core;
using SoftwareFactory.Adomysql;

namespace SoftwareFactory.GUI
{
    class AdoTest
    {
        public static IAdo ADO { get; set; } =
            FactoryAdoMySQL.GetAdoDesdeJson("appsettings.json", "test");
    }
}
