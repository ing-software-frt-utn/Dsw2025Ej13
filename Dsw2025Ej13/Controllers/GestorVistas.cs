using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej13.Presentation.Controllers;

public class GestorVistas
{
    private static GestorVistas? _instance;
    private IServiceProvider? _serviceProvider;
    private GestorVistas()
    {
    }
    public static GestorVistas Instance
    {
        get
        {
            return _instance ??= new GestorVistas();
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
