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

            var listadorClientes = new MenuListaCliente("Listado de Clientes");
            var menuCliente = new MenuCompuesto("Menu Cliente", new MenuAltaCliente(), listadorClientes);

            var menuProyecto = new MenuCompuesto("Menu Proyecto", new MenuAltaProyecto(listadorClientes), new MenuListaProyecto("Listado de Proyectos"));

            var menuPrincipal = new MenuCompuesto("Menu Administrador", menuCliente ,menuProyecto);

            menuPrincipal.mostrar();
        }
    }
}
