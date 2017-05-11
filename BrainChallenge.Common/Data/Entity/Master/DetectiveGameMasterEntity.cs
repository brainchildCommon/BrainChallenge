using SQLite;
using System.Text;

namespace BrainChallenge.Common.Data.Entity.Master
{
    /// <summary>
    /// 迷子を探せ!!マスターテーブルエンティティ
    /// </summary>
    [Table("DetectiveGameMaster")]
    public class DetectiveGameMasterEntity
    {
        /// <summary>
        /// レベル(PrimaryKey)
        /// </summary>
        [PrimaryKey, Column("_level")]
        public int Level { get; set; }
        /// <summary>
        /// ポイント
        /// </summary>
        [Column("_point")]
        public string Point { get; set; }
        /// <summary>
        /// タイル総数
        /// </summary>
        [Column("_tile")]
        public int Tile { get; set; }
        /// <summary>
        /// 正解タイル数
        /// </summary>
        [Column("_collectTile")]
        public int CollectTile { get; set; }
        /// <summary>
        /// フェイクタイルフラグ
        /// </summary>
        [Column("_fakeFlg")]
        public string FakeFlg { get; set; }
        /// <summary>
        /// フェイクタイル数
        /// </summary>
        [Column("_fakeTile")]
        public string FakeTile { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append("[");
            sb.Append("Level=" + Level);
            sb.Append(",");
            sb.Append("Point=" + Point);
            sb.Append(",");
            sb.Append("Tile=" + Tile);
            sb.Append(",");
            sb.Append("CollectTile=" + CollectTile);
            sb.Append(",");
            sb.Append("FakeFlg=" + FakeFlg);
            sb.Append(",");
            sb.Append("FakeTile=" + FakeTile);
            sb.Append("]");

            return sb.ToString();
        }
    }
}
