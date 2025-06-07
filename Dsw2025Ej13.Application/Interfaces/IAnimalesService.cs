using Dsw2025Ej13.Domain.Entities;

namespace Dsw2025Ej13.Application.Interfaces;

public interface IAnimalesService
{
    IEnumerable<Mamifero> GetMamiferos();
    Dictionary<TipoAlimentacion, double> GetTotalComida();
}
