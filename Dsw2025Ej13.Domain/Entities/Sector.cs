namespace Dsw2025Ej13.Domain.Entities;

public class Sector
{
    private int _numero;
    private double _latitud;
    private double _longitud;
    private int _limite;
    private TipoAlimentacion _tipoAlimentacion;
    private Empleado _empleado;
    private List<Mamifero> _animales = [];

    public Sector(int numero, double latitud, double longitud, int limite,
        TipoAlimentacion tipoAlimentacion, Empleado empleado)
    {
        if(empleado == null) throw new ArgumentNullException(nameof(empleado));
        _numero = numero;
        _latitud = latitud;
        _longitud = longitud;
        _limite = limite;
        _tipoAlimentacion = tipoAlimentacion;
        _empleado = empleado;
    }

    public int GetNumero()
    {
        return _numero;
    }
    public double GetLatitud()
    {
        return _latitud;
    }
    public double GetLongitud()
    {
        return _longitud;
    }
    public int GetLimite()
    {
        return _limite;
    }
    public TipoAlimentacion GetTipoAlimentacion()
    {
        return _tipoAlimentacion;
    }
    public Empleado GetEmpleado()
    {
        return _empleado;
    }
    public List<Mamifero> GetAnimales()
    {
        return _animales;
    }
    public override string ToString()
    {
        return _numero.ToString();
    }
}
