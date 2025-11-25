using Repositorio;

namespace Aplicacion;

public class ChallengeService : IChallengeService
{
    private readonly List<Challenge> _challenges = [];
    
    public void CreateChallenge(Challenge challenge)
    {
        var nextId = 0;
        if(_challenges.Count == 0)
        {
            nextId = 1;
        }
        else
        {
            nextId = _challenges.Count + 1;
        }

        challenge.Id = nextId;
    
        _challenges.Add(challenge);
    }

    public Challenge? GetById(int id)
    {
        foreach (Challenge reto in _challenges)
        {
            if(reto.Id == id)
            {
                return reto;
            }
        }
        return null;
    }

    public List<Challenge> GetAll()
    {
        return _challenges;
    }

    public void DeleteChallenge(int id)
    {
        foreach (Challenge reto in _challenges)
        {
            if(reto.Id == id)
            {

                _challenges.Remove(reto);
            }
        }
    }
        
}
