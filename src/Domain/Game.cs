namespace Domain;
public class Game
{
    private readonly List<int> _highscores = new();
    private Dice _dice1 = default!;
    private Dice _dice2 = default!;

    public int Eye1 => _dice1.Dots;
    public int Eye2 => _dice2.Dots;

    public bool HasSnakeEyes => Eye1 == 1 && Eye2 == 1;
    public IReadOnlyList<int> HighScores => _highscores.AsReadOnly();
    
    public int Total { get; private set; }

    public Game()
    {
        Initialize();
    }

    private void Initialize()
    {
        _dice1 = new Dice();
        _dice2 = new Dice();
    }

    public void Play()
    {
        _dice1.Roll();
        _dice2.Roll();
        if (HasSnakeEyes)
        { 
            _highscores.Add(Total);
            Total = 0;
        }
        else
        {
            Total += (_dice1.Dots + _dice2.Dots);
        }
    }

    public void Restart()
    {
        Initialize();
    }
}