using Dsw2025Ej13.Presentation.Interfaces;

namespace Dsw2025Ej13.Presentation.Controllers;

public class MenuControlador: IControlador
{
    private readonly IMenuView _vista;

    public MenuControlador(IMenuView vista)
    {
        _vista = vista;
        _vista.SetControlador(this);
        _vista.DibujarMenu();
    }

    public void ListarAnimales()
    {
        GestorControladores.Instance.NavegarA<ListarAnimalesControlador>();
    }
}
