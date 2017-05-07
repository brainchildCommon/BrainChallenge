using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrainChallenge.Common.Client.ClientModel;

namespace BrainChallenge.Common.Client.ClientService.InterFace
{
    interface IHelpService
    {
        GameHelpModel GetHelpModel(int gameId);
    }
}
