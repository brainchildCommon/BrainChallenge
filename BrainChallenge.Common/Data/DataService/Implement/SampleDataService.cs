﻿using System.Collections.Generic;
using System.Linq;
using BrainChallenge.Common.Data.Connection;
using BrainChallenge.Common.Data.Entity.General;
using BrainChallenge.Common.Data.Service.Interface;

namespace BrainChallenge.Common.Data.DataService.Implement
{
    public class SampleDataService : IGeneralDataService<SampleEntity>
    {
        public bool Insert(SampleEntity t)
        {
            using (var con = ConnectionProvider.GetConnection())
            {
                var result = con.Insert(t);

                return result == 1;
            }
        }

        public List<SampleEntity> Select()
        {
            using (var con = ConnectionProvider.GetConnection())
            {
                var result = from record in con.Table<SampleEntity>() select record;

                return result.Count() != 0 ? result.ToList() : null;
            }
        }

        public List<SampleEntity> Select(SampleEntity t)
        {
            using (var con = ConnectionProvider.GetConnection())
            {
                var result = from record in con.Table<SampleEntity>() select record;

                if (t.Id != -1)
                    result = result.Where(data => data.Id == t.Id);
                if (t.Name != null)
                    result = result.Where(data => data.Name.Equals(t.Name));

                return result.Count() != 0 ? result.ToList() : null;
            }
        }
    }
}