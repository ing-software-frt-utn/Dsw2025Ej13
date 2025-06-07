using Dsw2025Ej13.Application.Interfaces;
using Dsw2025Ej13.Domain.Entities;
using Dsw2025Ej13.Presentation.Interfaces;
using Dsw2025Ej13.Presentation.Models;

namespace Dsw2025Ej13.Presentation.Controllers;

public class ListarAnimalesControlador: IControlador
{
    private readonly IAnimalesService _animalesService;
    private readonly IListarAnimalesView _vista;

    public ListarAnimalesControlador(IAnimalesService animalesService,
        IListarAnimalesView vista)
    {
        _animalesService = animalesService;
        _vista = vista;
        _vista.SetControlador(this);
        _vista.ListarAnimales();
    }

    public List<AnimalViewModel> ObtenerAnimales()
    {
        return [.. _animalesService
            .GetMamiferos()
            .Select(m=> new AnimalViewModel(m))];
    }

    public ComidaViewModel CalcularComida()
    {
        var total = _animalesService.GetTotalComida();
        return new ComidaViewModel(total[TipoAlimentacion.CARNIVORO], total[TipoAlimentacion.HERBIVORO]);
    }
}
