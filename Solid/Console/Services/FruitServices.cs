using Application.ValueObjects;
using Application.ValueObjects.Common;

namespace Application.Services;

public class FruitServices
{
    public string ColorWrong()
    {
        Apple apple = new Pineapple();
        return apple.GetColor();
    }

    public void Color()
    {
        var fruits = new Fruit[] { new AppleObject(), new PineappleObject() };

        foreach ( var fruit in fruits )
        {
            Console.WriteLine(fruit.GetColor());
        }
    }
}
