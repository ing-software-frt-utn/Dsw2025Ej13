using Dsw2025Ej13.Presentation.Controllers;
using Dsw2025Ej13.Presentation.Models;

namespace Dsw2025Ej13.Presentation.Views;

public class ConsoleView
{
    private readonly Controlador _controlador;

    public ConsoleView(Controlador controlador)
    {
        _controlador = controlador;
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
                ListarAnimales();
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Agregando animal...");
            }
        }
        while (opcion != "3");
    }
    public void CentrarTexto(string? texto, out int usado, int? ancho = null, bool salto = true)
    {
        texto ??= string.Empty;
        ancho ??= Console.WindowWidth;
        int largo = texto.Length;
        int espacios = (ancho.Value - largo) / 2;
        espacios = espacios % 2 == 0 ? espacios : espacios + 1;
        string fin = salto ? "\n" : string.Empty;
        string final = new string(' ', espacios) + texto + fin;
        Console.Write(final);
        usado = final.Length;
    }
    public void LimpiarPantalla()
    {
        Console.Clear();
    }
    public void DibujarLinea()
    {
        var with = Console.WindowWidth;
        for (int i = 0; i < with; i++)
        {
            Console.Write("-");
        }
    }
    private void ListarAnimales()
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
        ComidaViewModel totalComida = _controlador.CalcularComida();
        DibujarLinea();
        Console.WriteLine($"Total de comida Carnívoros: {totalComida.GetCarnivoros()} Kgs.");
        Console.WriteLine($"Total de comida Herbívoros: {totalComida.GetHerbivoros()} Kgs.");
        Console.WriteLine($"Total de comida: {totalComida.GetTotal()} Kgs.");
        DibujarLinea();
        Console.Write("\n");
        Console.Write("\n");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadLine();
    }
    private void DibujarEncabezado(params string[] columnas)
    {
        DibujarLinea();
        int ancho = Console.WindowWidth / columnas.Length;
        
        foreach (var columna in columnas)
        {
            Console.Write("|");
            CentrarTexto(columna, out int l, ancho - 1, false);
            Console.Write("".PadRight(ancho - 1 - l));
        }
        Console.Write("\n");
        DibujarLinea();
    }
    private void DibjuarDatos(int columnas)
    {
        List<AnimalViewModel> animales = _controlador.ObtenerAnimales();
        int ancho = Console.WindowWidth / columnas;
        foreach (var animal in animales)
        {
            Console.Write("|");
            CentrarTexto(animal.GetEspecie(), out int l, ancho- 1, false);
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
}
