namespace Dsw2025Ej13.Domain.Entities;

public abstract class Mamifero
{
    protected int _edad;
    protected double _peso;
    protected TipoAlimentacion _tipoAlimentacion;
    protected Especie? _especie;
    protected Sector? _sector;

    protected Mamifero(TipoAlimentacion tipoAlimentacion, int edad, double peso,
        Especie? especie, Sector? sector)
    {
        _tipoAlimentacion = tipoAlimentacion;
        _edad = edad;
        _peso = peso;
        _especie = especie;
        _sector = sector;
    }

    public abstract double CalcularCantidadDeComida();

    public int GetEdad()
    {
        return _edad;
    }
    public double GetPeso()
    {
        return _peso;
    }
    public TipoAlimentacion GetTipoAlimentacion()
    {
        return _tipoAlimentacion;
    }
    public Especie? GetEspecie()
    {
        return _especie;
    }
    public Sector? GetSector()
    {
        return _sector;
    }
    public bool TieneAlimentacion(TipoAlimentacion tipo)
    {
        return _tipoAlimentacion == tipo;
    }
}
