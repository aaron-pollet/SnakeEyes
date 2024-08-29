namespace Domain;
public class Game
{
    private readonly List<int> _highscores = new();
    private Dice _dice1 = new Dice();
    private Dice _dice2 = new Dice();
    
    public int Eye1 { get; }
    public int Eye2 { get; }
    
    public bool HasSnakeEyes { get; }
    public IReadOnlyList<int> HighScores;
    
    public int Total { get; set; }

    public Game()
    {
        throw new NotImplementedException();       
    }

    private void Initialize()
    {
        throw new NotImplementedException();
    }

    public void Play()
    {
        throw new NotImplementedException();
        
    }

    public void Restart()
    {
        throw new NotImplementedException();
    }
}