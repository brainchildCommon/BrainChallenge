using System.Collections.Generic;
using System.Text;

namespace BrainChallenge.Common.Client.ClientModel
{
    public class GameResultDetailModel
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
        ///     ゲームアイコン画像名
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        ///     ゲームタイトル画像名
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     コントローラクラス名
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        ///     スコア(上位5位)
        /// </summary>
        public List<int> Score { get; set; }

        /// <summary>
        ///     スコア結果
        /// </summary>
        public int ResultScore { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("[");
            sb.Append("GameId=" + GameId);
            sb.Append(",");
            sb.Append("GameName=" + GameName);
            sb.Append(",");
            sb.Append("Icon=" + Icon);
            sb.Append(",");
            sb.Append("Title=" + Title);
            sb.Append(",");
            sb.Append("Class=" + Class);
            sb.Append(",");
            sb.Append("Score=" + Score);
            sb.Append(",");
            sb.Append("ResultScore=" + ResultScore);
            sb.Append("]");

            return sb.ToString();
        }
    }
}