using System.Threading.Tasks;
using WorldCupTeams.DTOS;

namespace WorldCupTeams.Services
{
    public interface IWorldCupService
    {
        TeamDTO[] FindTeamBy(string Name);
        TeamDTO[] FindAll();
        TeamDTO FindTeamBy(int key);
    }
}
