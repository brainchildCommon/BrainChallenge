using BrainChallenge.Common.Client.ClientModel;

namespace BrainChallenge.Common.Client.ClientService.InterFace
{
    interface IGameResultService
    {
        GameResultDetailModel GetGameResultDetail(int gameId, long score);
    }
}
