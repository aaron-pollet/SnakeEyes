namespace Domain;

public class Dice
{
    private Random _randomizer = default!;

    public int Dots = default!;

    public Dice()
    {
        Dots = 6;
    }

    public void Roll()
    {
        Dots = _randomizer.Next(1, 7);
    }
}