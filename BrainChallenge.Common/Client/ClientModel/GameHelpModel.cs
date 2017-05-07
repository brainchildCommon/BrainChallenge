using System.Collections.Generic;
using System.Text;

namespace BrainChallenge.Common.Client.ClientModel
{
    public class GameHelpModel
    {
        /// <summary>
        ///     ゲームID
        /// </summary>
        public int GameId { get; set; }

        /// <summary>
        ///     ゲーム名
        /// </summary>
        public string GameName { get; set; }

        /// <summary>
        ///     ヘルプ情報
        /// </summary>
        public List<HelpModel> Help { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("[");
            sb.Append("GameId=" + GameId);
            sb.Append(",");
            sb.Append("GameName=" + GameName);
            sb.Append(",");
            sb.Append("Help=" + Help);
            sb.Append("]");

            return sb.ToString();
        }
    }
}
