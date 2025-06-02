using Dsw2025Ej13.Data;
using Dsw2025Ej13.Domain;

namespace Dsw2025Ej13.Presentation;

public class Controlador
{
    public static List<AnimalViewModel> ObtenerAnimales()
    {
        List<AnimalViewModel> animales = [];
        foreach (var animal in Persistencia.GetMamiferos())
        {
            animales.Add(new AnimalViewModel(animal));
        }
        return animales;
    }

    public static ComidaViewModel CalcularComida()
    {
        double totalCarnivoros = Persistencia.GetTotalComida(TipoAlimentacion.CARNIVORO);
        double totalHerbivoros = Persistencia.GetTotalComida(TipoAlimentacion.HERBIVORO);
        return new ComidaViewModel(totalCarnivoros, totalHerbivoros);
    }
}
