namespace Barly.Domain;

public class Drink(string name, double price)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; } = name;
    public double Price { get; private set; } = price;
    public List<string> Ingredients { get; private set; } = [];

    public void AddIngredient(string ingredient)
    {
        Ingredients.Add(ingredient);
    }
}
