using et12.edu.ar.AGBD.Ado;
using et12.edu.ar.MenuesConsola;
using SoftwareFactory.Adomysql;
using SoftwareFactory.Core;
using SoftwareFactory.GUI.Menu;

namespace SoftwareFactory.GUI
{
    class Program
    {
        static public IAdo Ado { get; private set; }
        
        static void Main(string[] args)
        {
            var adoAGBD =FactoryAdoAGBD.GetAdoMySQL("appSettings.json", "test");
            Ado = new AdoMySql(adoAGBD);

            var menuCliente = new MenuCompuesto() { Nombre = "Menu Cliente"};
            menuCliente.agregarMenu(new MenuAltaCliente());
            menuCliente.agregarMenu(new MenuListaCliente() { Nombre = "Lista Clientes"});

            menuCliente.mostrar();
        }
    }
}
