namespace Dsw2025Ej13.Domain.Entities;

public class Carnivoro: Mamifero
{
    private static double _porcentajeExtra = 0.1;
    private static double _pesoMaximo = 200;

    public Carnivoro(int edad, double peso, Especie? especie, Sector? sector) : 
        base(TipoAlimentacion.CARNIVORO, edad, peso, especie, sector)
    {
        
    }
    public static double GetPorcentajeExtra()
    {
        return _porcentajeExtra;
    }
    public static double GetPesoMaximo()
    {
        return _pesoMaximo;
    }
    public override double CalcularCantidadDeComida()
    {
        double porcentajeASumar = _peso > _pesoMaximo ? _porcentajeExtra : 0;
        return _peso * (_especie?.GetPorcentajePesoCarnivoro() ?? 0) * (1 + porcentajeASumar);
    }
}
