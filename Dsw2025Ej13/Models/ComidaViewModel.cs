namespace Dsw2025Ej13.Presentation.Models;

public class ComidaViewModel
{
    private double _carnivoros;
    private double _herbivoros;

    public ComidaViewModel(double carnivoros, double herbivoros)
    {
        _carnivoros = carnivoros;
        _herbivoros = herbivoros;
    }

    public double GetTotal()
    {
        return _carnivoros + _herbivoros;
    }

    public double GetCarnivoros()
    {
        return _carnivoros;
    }

    public double GetHerbivoros()
    {
        return _herbivoros;
    }
}
