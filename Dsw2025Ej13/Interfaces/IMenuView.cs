using Dsw2025Ej13.Presentation.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej13.Presentation.Interfaces;

public interface IMenuView: IBaseView<ControladorMenu>
{
    void DibujarMenu();
}
