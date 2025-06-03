using Dsw2025Ej13.Data;
using Dsw2025Ej13.Domain.Entities;
using Dsw2025Ej13.Domain.Interfaces;
using Dsw2025Ej13.Presentation.Models;

namespace Dsw2025Ej13.Presentation.Controllers;

public class Controlador
{
    private readonly IPersistencia _persistencia;

    public Controlador(IPersistencia persistencia)
    {
        _persistencia = new PersistenciaEnMemoria();
    }
    public List<AnimalViewModel> ObtenerAnimales()
    {
        List<AnimalViewModel> animales = [];
        foreach (var animal in _persistencia.GetMamiferos())
        {
            animales.Add(new AnimalViewModel(animal));
        }
        return animales;
    }

    public ComidaViewModel CalcularComida()
    {
        double totalCarnivoros = _persistencia.GetTotalComida(TipoAlimentacion.CARNIVORO);
        double totalHerbivoros = _persistencia.GetTotalComida(TipoAlimentacion.HERBIVORO);
        return new ComidaViewModel(totalCarnivoros, totalHerbivoros);
    }
}
