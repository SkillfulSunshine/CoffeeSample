namespace CoffeeSample.Decorators;

public class PumpkinSpiceDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    public PumpkinSpiceDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public double Cost() => _coffee.Cost() + 1.00;
    public string Description => $"{_coffee.Description}, with Pumpkin Spice";
}
