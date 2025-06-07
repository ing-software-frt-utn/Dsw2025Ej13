using Dsw2025Ej13.Application.Interfaces;
using Dsw2025Ej13.Application.Services;
using Dsw2025Ej13.Data;
using Dsw2025Ej13.Domain.Interfaces;
using Dsw2025Ej13.Presentation.Controllers;
using Dsw2025Ej13.Presentation.Interfaces;
using Dsw2025Ej13.Presentation.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Dsw2025Ej13;

internal class Program
{
    static void Main(string[] args)
    {
        var service = new ServiceCollection();
        service.AddTransient<IPersistencia, PersistenciaEnMemoria>();
        service.AddTransient<MenuControlador>();
        service.AddTransient<ListarAnimalesControlador>();
        service.AddTransient<IMenuView, MenuView>();
        service.AddTransient<IListarAnimalesView, ListarAnimalesView>();
        service.AddTransient<IAnimalesService, AnimalesService>();

        var provider = service.BuildServiceProvider();
        GestorControladores.Instance.SetProveedor(provider);
        GestorControladores.Instance.NavegarA<MenuControlador>();
    }
}
