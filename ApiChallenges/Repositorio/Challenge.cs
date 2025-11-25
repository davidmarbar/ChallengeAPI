namespace Repositorio;
public enum DifficultyLevel { Level1 = 1, Level2, Level3, Level4, Level5 }

public class Challenge
{
    public int Id{get; set;}
    public string Title {get; set;} = "";
    public string Description {get; set;} = "";
    public DifficultyLevel Difficulty {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
    
}