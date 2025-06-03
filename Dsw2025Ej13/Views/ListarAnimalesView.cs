using Dsw2025Ej13.Presentation.Controllers;
using Dsw2025Ej13.Presentation.Interfaces;
using Dsw2025Ej13.Presentation.Models;

namespace Dsw2025Ej13.Presentation.Views;

public class ListarAnimalesView: BaseView<ControladorListarAnimales>, IListarAnimalesView
{
    public void ListarAnimales()
    {
        LimpiarPantalla();
        string[] columnas = { "Especie", "Edad", "Peso", "Sector", "Porc. Carnivoro", "Valor Fijo" };
        DibujarEncabezado(columnas);
        DibjuarDatos(columnas.Length);
        DibujarLinea();
        Console.Write("\n");
        Console.Write("\n");
        Console.WriteLine("Presione una tecla para calcular el total de comida...");
        Console.ReadLine();
        DibujarTotales();
        Console.Write("\n");
        Console.Write("\n");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadLine();
    }

    private void DibjuarDatos(int columnas)
    {
        List<AnimalViewModel> animales = Controlador.ObtenerAnimales();
        int ancho = Console.WindowWidth / columnas;
        foreach (var animal in animales)
        {
            Console.Write("|");
            CentrarTexto(animal.GetEspecie(), out int l, ancho - 1, false);
            Console.Write("".PadRight(ancho - 1 - l));
            Console.Write("|");
            CentrarTexto(animal.GetEdad().ToString(), out l, ancho - 1, false);
            Console.Write("".PadRight(ancho - 1 - l));
            Console.Write("|");
            CentrarTexto(animal.GetPeso().ToString(), out l, ancho - 1, false);
            Console.Write("".PadRight(ancho - 1 - l));
            Console.Write("|");
            CentrarTexto(animal.GetSector(), out l, ancho - 1, false);
            Console.Write("".PadRight(ancho - 1 - l));
            Console.Write("|");
            CentrarTexto(animal.GetPorcentaje().ToString(), out l, ancho - 1, false);
            Console.Write("".PadRight(ancho - 1 - l));
            Console.Write("|");
            CentrarTexto(animal.GetValorFijo().ToString(), out l, ancho - 1, false);
            Console.Write("".PadRight(ancho - 1 - l));
        }
    }

    private void DibujarTotales()
    {
        ComidaViewModel totalComida = Controlador.CalcularComida();
        DibujarLinea();
        Console.WriteLine($"Total de comida Carnívoros: {totalComida.GetCarnivoros()} Kgs.");
        Console.WriteLine($"Total de comida Herbívoros: {totalComida.GetHerbivoros()} Kgs.");
        Console.WriteLine($"Total de comida: {totalComida.GetTotal()} Kgs.");
        DibujarLinea();
    }
}
