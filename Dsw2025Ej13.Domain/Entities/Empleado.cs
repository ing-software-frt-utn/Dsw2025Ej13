namespace Dsw2025Ej13.Domain.Entities;

public class Empleado
{
    private string _nombre;
    private string _documento;
    private string _domicilio;
    
    public Empleado(string nombre, string documento, string domicilio)
    {
        _nombre = nombre;
        _documento = documento;
        _domicilio = domicilio;
    }
    public string GetNombre()
    {
        return _nombre;
    }
    public string GetDocumento()
    {
        return _documento;
    }
    public string GetDomicilio()
    {
        return _domicilio;
    }
}
