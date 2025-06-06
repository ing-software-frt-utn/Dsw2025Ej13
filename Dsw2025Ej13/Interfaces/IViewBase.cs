namespace Dsw2025Ej13.Presentation.Interfaces;

public interface IViewBase<T>
    where T : IControlador
    
{
    T Controlador { get; }
    void SetControlador(T controlador);
}
