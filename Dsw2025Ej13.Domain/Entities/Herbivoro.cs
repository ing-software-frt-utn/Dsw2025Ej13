namespace Dsw2025Ej13.Domain.Entities;

public class Herbivoro: Mamifero
{
    private static double _porcentajePeso = 2;
    private double _valorFijo;
    public Herbivoro(int edad, double peso, Especie? especie, Sector? sector, double valorFijo): 
        base(TipoAlimentacion.HERBIVORO, edad, peso, especie, sector)
    {
        _valorFijo = valorFijo;
    }
    public static double GetPorcentajePeso()
    {
        return _porcentajePeso;
    }
    public double GetValorFijo()
    {
        return _valorFijo;
    }

    public override double CalcularCantidadDeComida()
    {
        return _peso * _porcentajePeso + _valorFijo;
    }
}
