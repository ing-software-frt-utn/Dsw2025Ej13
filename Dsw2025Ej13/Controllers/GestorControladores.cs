namespace Dsw2025Ej13.Presentation.Controllers;

public class GestorControladores
{
    private static GestorControladores? _instance;
    private IServiceProvider? _serviceProvider;
    private GestorControladores()
    {
    }
    public static GestorControladores Instance
    {
        get
        {
            return _instance ??= new GestorControladores();
        }
    }

    public void SetProveedor(IServiceProvider provider)
    {
        _serviceProvider = provider;
    }

    public void NavegarA<T>()
    {
        if (_serviceProvider == null) return;
        _ = _serviceProvider.GetService(typeof(T));
    }
}
