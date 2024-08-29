namespace Domain;

public class Dice
{
    private Random _randomizer = default!;

    public int Dots { get; set; }

    public Dice()
    {
        // Dots = 1;
        throw new NotImplementedException();
    }

    public void Roll()
    {
        //i want a random number between 1 and 6 (included)
        // Dots = _randomizer.Next(1, 7);
        throw new NotImplementedException();
    }
}