using Dsw2025Ej13.Presentation.Interfaces;

namespace Dsw2025Ej13.Presentation.Controllers;

public class ControladorMenu: IControlador
{
    private readonly IMenuView _vista;

    public ControladorMenu(IMenuView vista)
    {
        _vista = vista;
        _vista.SetControlador(this);
        _vista.DibujarMenu();
    }

    public void ListarAnimales()
    {
        GestorVistas.Instance.NavegarA<ControladorListarAnimales>();
    }
}
