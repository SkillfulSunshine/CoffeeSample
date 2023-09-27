var coffees = new List<ICoffee>
{
    new PumpkinSyrupDecorator(new PumpkinSpiceDecorator(new MilkDecorator(new BasicCoffee()))),
    new PumpkinSyrupDecorator(new PumpkinSpiceDecorator(new BasicCoffee())),
    new MilkDecorator(new BasicCoffee()),
    new BasicCoffee()
};

foreach (var coffee in coffees)
{
    Console.WriteLine($"{coffee.Description}: ${coffee.Cost()}");
}
