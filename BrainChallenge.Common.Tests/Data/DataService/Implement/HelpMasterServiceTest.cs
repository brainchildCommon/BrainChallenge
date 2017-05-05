using System.Collections.Generic;
using System.Linq;
using BrainChallenge.Common.Data.Connection;
using BrainChallenge.Common.Data.Entity.General;
using BrainChallenge.Common.Data.Service.Interface;
using BrainChallenge.Common.Data.Entity.Master;
using System.Runtime.CompilerServices;
using NUnit.Framework;
using BrainChallenge.Common.Data.DataService.Implement;

#if DEBUG
[assembly: InternalsVisibleTo("BrainChallenge.Common")]
#endif

namespace BrainChallenge.Common.Tests.Data.DataService.Implement
{
    [TestFixture]
    class HelpMasterServiceTest
    {

        private HelpMasterService _serv;

        [SetUp]
        public void Setup()
        {
            _serv = new HelpMasterService();
        }


        [TearDown]
        public void Tear() { }

        [Test]
        public void SelectAllTest1()
        {
            Assert.True(_serv.Select().Count == TestData.HelpMasterTestData.Count);
        }

        [Test]
        public void SelectAllTest2()
        {
            var result = _serv.Select();

            var selectString = "";
            var testDataString = "";

            result.ForEach(data => selectString += data.ToString());
            TestData.HelpMasterTestData.ForEach(data => testDataString += data.ToString());

            Assert.True(selectString.Equals(testDataString));
        }

        [Test]
        public void SelectAndTest1()
        {
            var result = _serv.Select(TestData.HelpMasterTestData[0]);

            Assert.True(result[0].ToString().Equals(TestData.HelpMasterTestData[0].ToString()));

        }
        [Test]
        public void SelectAndTest2()
        {
            var result = _serv.Select(new HelpMasterEntity { GameId = 3, Explain = "ゲームの説明1", HelpIndex = 0, Image = "help_image01" });

            Assert.True(result[0].ToString().Equals(TestData.HelpMasterTestData[7].ToString()));

        }

    }
}
