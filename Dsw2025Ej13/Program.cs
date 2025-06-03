using Dsw2025Ej13.Data;
using Dsw2025Ej13.Domain.Interfaces;
using Dsw2025Ej13.Presentation.Controllers;
using Dsw2025Ej13.Presentation.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Dsw2025Ej13;

internal class Program
{
    
    static void Main(string[] args)
    {
        var service = new ServiceCollection();
        service.AddTransient<IPersistencia, PersistenciaEnMemoria>();
        service.AddTransient<Controlador>();
        service.AddTransient<ConsoleView>();

        var provider = service.BuildServiceProvider();
        var console = provider.GetService<ConsoleView>();
        console?.DibujarMenu();
    }
}
