using Dsw2025Ej13.Application.Interfaces;
using Dsw2025Ej13.Domain.Entities;
using Dsw2025Ej13.Domain.Interfaces;

namespace Dsw2025Ej13.Application.Services;

public class AnimalesService : IAnimalesService
{
    private readonly IPersistencia _persistencia;

    public AnimalesService(IPersistencia persistencia)
    {
        _persistencia = persistencia;
    }
    public IEnumerable<Mamifero> GetMamiferos()
    {
        return _persistencia.GetMamiferos();
    }

    public Dictionary<TipoAlimentacion, double> GetTotalComida()
    {
        return _persistencia.GetTotalComida();
    }
}
