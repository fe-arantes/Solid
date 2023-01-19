using Application.ValueObjects.Common;

namespace Application.ValueObjects;

public class AppleObject : Fruit
{
    public override string GetColor()
    {
        return "Red";
    }
}
