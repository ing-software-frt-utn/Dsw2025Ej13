using Dsw2025Ej13.Domain.Entities;

namespace Dsw2025Ej13.Domain.Interfaces;

public interface IPersistencia
{
    Especie? GetEspecie(int codigo);
    IEnumerable<Mamifero> GetMamiferos();
    Sector? GetSector(int numero);
    Dictionary<TipoAlimentacion, double> GetTotalComida();
}