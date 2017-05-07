using System.Text;

namespace BrainChallenge.Common.Client.ClientModel
{
    public class HelpModel
    {
        /// <summary>
        ///     ヘルプイメージ
        /// </summary>
        public string HelpImage { get; set; }

        /// <summary>
        ///     説明
        /// </summary>
        public string Explain { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("[");
            sb.Append("HelpImage=" + HelpImage);
            sb.Append(",");
            sb.Append("Explain=" + Explain);
            sb.Append("]");

            return sb.ToString();
        }
    }
}