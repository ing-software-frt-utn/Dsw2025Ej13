using Dsw2025Ej13.Data;
using Dsw2025Ej13.Domain.Entities;
using Dsw2025Ej13.Domain.Interfaces;
using Dsw2025Ej13.Presentation.Interfaces;
using Dsw2025Ej13.Presentation.Models;

namespace Dsw2025Ej13.Presentation.Controllers;

public class ControladorListarAnimales: IControlador
{
    private readonly IPersistencia _persistencia;
    private readonly IListarAnimalesView _vista;

    public ControladorListarAnimales(IPersistencia persistencia,
        IListarAnimalesView vista)
    {
        _persistencia = persistencia;
        _vista = vista;
        _vista.SetControlador(this);
        _vista.ListarAnimales();
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
