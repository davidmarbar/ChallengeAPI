using Repositorio;
namespace Aplicacion;

public interface IChallengeService
{
    void CreateChallenge(Challenge challenge);
    Challenge? GetById(int id);
    List<Challenge> GetAll();
    void DeleteChallenge(int id);    
}