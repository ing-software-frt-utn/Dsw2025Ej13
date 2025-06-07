using Dsw2025Ej13.Presentation.Controllers;
using Dsw2025Ej13.Presentation.Interfaces;

namespace Dsw2025Ej13.Presentation.Views;

public class MenuView : ViewBase<MenuControlador>, IMenuView
{
    public MenuView()
    {
        
    }
    public void DibujarMenu()
    {
        string? opcion = null;
        do
        {
            LimpiarPantalla();
            DibujarLinea();
            CentrarTexto("Menú Principal - Zoológico", out int _);
            DibujarLinea();
            Console.WriteLine("Elija una opción: \n");
            Console.WriteLine("1. Listar animales");
            Console.WriteLine("2. Agregar animal");
            Console.WriteLine("3. Salir");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese su opción: ");
            opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.WriteLine("Listando animales...");
                Controlador.ListarAnimales();
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Agregando animal...");
            }
        }
        while (opcion != "3");
    }
}
