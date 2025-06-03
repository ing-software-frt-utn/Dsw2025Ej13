using Dsw2025Ej13.Presentation.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej13.Presentation.Interfaces;

public interface IBaseView<T>
    where T : IControlador
    
{
    T Controlador { get; }
    void SetControlador(T controlador);
}
