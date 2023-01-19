using Application.ValueObjects.Common;

namespace Application.ValueObjects;

public class PineappleObject : Fruit
{
    public override string GetColor()
    {
        return "Yellow";
    }
}
