using Dsw2025Ej13.Domain.Entities;

namespace Dsw2025Ej13.Presentation.Models;

public record AnimalViewModel
{
    private string? _especie;
    private int _edad;
    private string? _sector;
    private double _peso;
    private double _valorFijo;
    private double _porcentaje;

    public AnimalViewModel(Mamifero animal)
    {
        if (animal == null) return;
        _especie = animal.GetEspecie()?.GetNombre();
        _edad = animal.GetEdad();
        _sector = animal.GetSector()?.ToString();
        _peso = animal.GetPeso();
        _valorFijo = animal is Herbivoro herbivoro ? herbivoro.GetValorFijo() : 0;
        _porcentaje = animal is Carnivoro carnivoro ? carnivoro.GetEspecie()?.GetPorcentajePesoCarnivoro() ?? 0 : 0;
    }

    public string? GetEspecie()
    {
        return _especie;
    }

    public int GetEdad()
    {
        return _edad;
    }

    public string? GetSector()
    {
        return _sector;
    }

    public double GetPeso()
    {
        return _peso;
    }

    public double GetValorFijo()
    {
        return _valorFijo;
    }

    public double GetPorcentaje()
    {
        return _porcentaje;
    }
}
