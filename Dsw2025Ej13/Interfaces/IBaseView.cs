namespace Dsw2025Ej13.Presentation.Interfaces;

public interface IBaseView<T>
    where T : IControlador
    
{
    T Controlador { get; }
    void SetControlador(T controlador);
}
