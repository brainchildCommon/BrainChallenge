using BrainChallenge.Common.Data.Connection;
using BrainChallenge.Common.Data.Entity.Master;
using BrainChallenge.Common.Data.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainChallenge.Common.Data.DataService.Implement
{
    public class DetectiveGameMasterService : IMasterDataService<DetectiveGameMasterEntity>
    {
        public List<DetectiveGameMasterEntity> Select()
        {
            using (var con = ConnectionProvider.GetConnection())
            {
                var result = from record in con.Table<DetectiveGameMasterEntity>() select record;

                return result.Count() != 0 ? result.ToList() : null;
            }
        }

        public List<DetectiveGameMasterEntity> Select(DetectiveGameMasterEntity t)
        {
            using (var con = ConnectionProvider.GetConnection())
            {
                var result = from record in con.Table<DetectiveGameMasterEntity>() select record;

                if (t.Level != -1)
                    result = result.Where(data => data.Level == t.Level);
                if (t.Point != null)
                    result = result.Where(data => data.Point.Equals(t.Point));
                if (t.Tile != -1)
                    result = result.Where(data => data.Tile == t.Tile);
                if (t.CollectTile != -1)
                    result = result.Where(data => data.CollectTile == t.CollectTile);
                if (t.FakeFlg != null)
                    result = result.Where(data => data.FakeFlg.Equals(t.FakeFlg));
                if (t.FakeTile != null)
                    result = result.Where(data => data.FakeTile.Equals(t.FakeTile));

                return result.Count() != 0 ? result.ToList() : null;
            }
        }
    }
}