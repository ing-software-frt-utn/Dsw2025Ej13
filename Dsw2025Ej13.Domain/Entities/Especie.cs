namespace Dsw2025Ej13.Domain.Entities;

public class Especie
{
    private int _codigo;
    private string _nombre;
    private double _porcentajePesoCarnivoro;
    private TipoAlimentacion _tipoAlimentacion;
    public Especie(int codigo, string nombre, double porcentajePesoCarnivoro, TipoAlimentacion tipoAlimentacion)
    {
        _codigo = codigo;
        _nombre = nombre;
        _porcentajePesoCarnivoro = tipoAlimentacion == TipoAlimentacion.CARNIVORO ? porcentajePesoCarnivoro : 0;
        _tipoAlimentacion = tipoAlimentacion;
    }

    public int GetCodigo()
    {
        return _codigo;
    }
    public string GetNombre()
    {
        return _nombre;
    }
    public double GetPorcentajePesoCarnivoro()
    {
        return _porcentajePesoCarnivoro;
    }
    public TipoAlimentacion GetTipoAlimentacion()
    {
        return _tipoAlimentacion;
    }
    public override string ToString()
    {
        return _nombre;
    }
}
