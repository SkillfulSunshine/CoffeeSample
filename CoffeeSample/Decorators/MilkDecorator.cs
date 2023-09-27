namespace CoffeeSample.Decorators;

public class MilkDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    public MilkDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public double Cost() => _coffee.Cost() + 1.50;
    public string Description => $"{_coffee.Description}, with Milk";
}
