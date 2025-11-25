using Repositorio;

namespace Presentacion;

public class ChallengeCreateDto
{
    public string Title {get;set;} = "";
    public string Description {get;set;} = "";
    //public DifficultyLevel difficulty {get;set;}
    public int difficulty {get;set;}

}