namespace CoffeeSample.Decorators;

public class PumpkinSyrupDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    public PumpkinSyrupDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public double Cost() => _coffee.Cost() + 2.00;
    public string Description => $"{_coffee.Description}, with Pumpkin Syrup";
}
