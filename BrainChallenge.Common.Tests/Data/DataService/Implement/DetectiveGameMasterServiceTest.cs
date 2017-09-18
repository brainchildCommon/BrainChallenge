using NUnit.Framework;
using BrainChallenge.Common.Data.DataService.Implement;
using BrainChallenge.Common.Data.Entity.General;
using System.Linq;
using System.Runtime.CompilerServices;
using BrainChallenge.Common.Data.Entity.Master;

#if DEBUG
[assembly: InternalsVisibleTo("BrainChallenge.Common")]
#endif

namespace BrainChallenge.Common.Tests.Data.DataService.Implement
{
    [TestFixture]
    class DetectiveGameMasterServiceTest
    {

        private DetectiveGameMasterService _serv;

        [SetUp]
        public void Setup()
        {
            _serv = new DetectiveGameMasterService();
        }


        [TearDown]
        public void Tear()
        {
        }

        [Test]
        public void SelectAllTest1()
        {
            Assert.True(_serv.Select().Count == TestData.DetectiveGameMasterTestData.Count);
        }
        [Test]
        public void SelectAllTest2()
        {
            var result = _serv.Select();

            var selectString = "";
            var testDataString = "";

            result.ForEach(data => selectString += data.ToString());
            TestData.DetectiveGameMasterTestData.ForEach(data => testDataString += data.ToString());

            Assert.True(selectString.Equals(testDataString));
        }

        [Test]
        public void SelectAndTest1()
        {
            var result = _serv.Select(TestData.DetectiveGameMasterTestData[0]);

            Assert.True(result[0].ToString().Equals(TestData.DetectiveGameMasterTestData[0].ToString()));

        }
        [Test]
        public void SelectAndTest2()
        {
            var result = _serv.Select(new DetectiveGameMasterEntity { Level = 6, Point = 600, Tile = 9, CollectTile = 4, FakeFlg = true, FakeTile = 2 });

            Assert.True(result[0].ToString().Equals(TestData.DetectiveGameMasterTestData[5].ToString()));
        }

        [Test]
        public void SelectAndTest3()
        {
            var result = _serv.Select(new DetectiveGameMasterEntity { Level = -1, Point = 400, Tile = 7, CollectTile = 3, FakeFlg = null, FakeTile = 1 });

            Assert.True(result[0].ToString().Equals(TestData.DetectiveGameMasterTestData[3].ToString()));
        }

        [Test]
        public void SelectAndTest4()
        {
            var result = _serv.Select(new DetectiveGameMasterEntity { Level = 1, Point = 100, Tile = 4, CollectTile = 1, FakeFlg = false, FakeTile = 0 });

            Assert.True(result == null);
        }
    }
}