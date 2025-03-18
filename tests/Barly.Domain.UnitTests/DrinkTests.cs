namespace Barly.Domain.UnitTests;

[TestClass]
public class DrinkTests
{
    [TestMethod]
    public void Constructor_ShouldInitializeProperties()
    {
        // Arrange
        var name = "Coke";
        var price = 1.5;

        // Act
        var drink = new Drink(name, price);

        // Assert
        Assert.AreEqual(name, drink.Name);
        Assert.AreEqual(price, drink.Price);
        Assert.AreEqual(0, drink.Ingredients.Count);
    }

    [TestMethod]
    public void AddIngredient_ShouldIncreaseIngredientsCount()
    {
        // Arrange
        var drink = new Drink("Coke", 1.5);
        var ingredient = "Sugar";

        // Act
        drink.AddIngredient(ingredient);

        // Assert
        Assert.AreEqual(1, drink.Ingredients.Count);
        Assert.AreEqual(ingredient, drink.Ingredients.First());
    }
}
