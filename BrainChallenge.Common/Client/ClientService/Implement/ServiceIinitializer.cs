using System;
using System.Collections.Generic;
using BrainChallenge.Common.Client.ClientModel;
using BrainChallenge.Common.Data.Connection;
using BrainChallenge.Common.Data.Entity.General;
using BrainChallenge.Common.Data.Entity.Master;
using BrainChallenge.Common.Util.Extentions;

namespace BrainChallenge.Common.Client.ClientService.Implement
{
    public class ServiceIinitializer
    {
        public static void Initialize(ServiceInitializeModel init)
        {
            ConnectionProvider.DbPath = init.DbPath;
            DbInitialize();
        }

        private static void DbInitialize()
        {
            using (var con = ConnectionProvider.GetConnection())
            {
                try
                {
                    //テーブルを削除
                    con.DropTable<GameTypeMasterEntity>();
                    con.DropTable<GameMasterEntity>();
                    con.DropTable<HelpMasterEntity>();
                    con.DropTable<ScoreEntity>();

                    con.DropTable<SampleEntity>();
                }
                catch (Exception e)
                {
                }


                //テーブルを作成
                con.CreateTable<GameTypeMasterEntity>();
                con.CreateTable<GameMasterEntity>();
                con.CreateTable<HelpMasterEntity>();
                con.CreateTable<ScoreEntity>();

                con.CreateTable<SampleEntity>();
            }

            LoadingData();
        }

        private static void LoadingData()
        {
            using (var con = ConnectionProvider.GetConnection())
            {
                var gameMasterTestData = new List<GameMasterEntity>();
                var gameTypeMasterTestData = new List<GameTypeMasterEntity>();
                var helpMasterTestData = new List<HelpMasterEntity>();
                var scoreTestData = new List<ScoreEntity>();

                gameTypeMasterTestData.Add(new GameTypeMasterEntity { GameTypeId = 0, Name = "記憶力" });
                gameTypeMasterTestData.Add(new GameTypeMasterEntity { GameTypeId = 1, Name = "柔軟性" });
                gameTypeMasterTestData.Add(new GameTypeMasterEntity { GameTypeId = 2, Name = "スピード" });
                gameTypeMasterTestData.Add(new GameTypeMasterEntity { GameTypeId = 3, Name = "問題解決能力" });

                gameMasterTestData.Add(new GameMasterEntity
                {
                    GameId = 0,
                    GameName = "迷子を探せ!!",
                    GameTypeId = 0,
                    ScoreType = 0,
                    TitleImage = "detective_game_title",
                    IconImage = "detective_game_icon",
                    Class = "DetectiveGameController",
                    GameTime = 1L
                });
                gameMasterTestData.Add(new GameMasterEntity
                {
                    GameId = 1,
                    GameName = "記憶力ゲーム2",
                    GameTypeId = 0,
                    ScoreType = 1,
                    TitleImage = "detective_game_title",
                    IconImage = "detective_game_icon",
                    Class = "MemoryGame2Controller",
                    GameTime = 2L
                });
                gameMasterTestData.Add(new GameMasterEntity
                {
                    GameId = 2,
                    GameName = "記憶力ゲーム3",
                    GameTypeId = 0,
                    ScoreType = 0,
                    TitleImage = "detective_game_title",
                    IconImage = "detective_game_icon",
                    Class = "MemoryGame3Controller",
                    GameTime = 3L
                });
                gameMasterTestData.Add(new GameMasterEntity
                {
                    GameId = 3,
                    GameName = "記憶力ゲーム4",
                    GameTypeId = 0,
                    ScoreType = 1,
                    TitleImage = "detective_game_title",
                    IconImage = "detective_game_icon",
                    Class = "MemoryGame4Controller",
                    GameTime = 4L
                });

                gameMasterTestData.Add(new GameMasterEntity
                {
                    GameId = 4,
                    GameName = "柔軟性ゲーム1",
                    GameTypeId = 1,
                    ScoreType = 0,
                    TitleImage = "detective_game_title",
                    IconImage = "detective_game_icon",
                    Class = "FlexibilityGame1Controller",
                    GameTime = 1L
                });

                gameMasterTestData.Add(new GameMasterEntity
                {
                    GameId = 5,
                    GameName = "スピードゲーム1",
                    GameTypeId = 2,
                    ScoreType = 0,
                    TitleImage = "detective_game_title",
                    IconImage = "detective_game_icon",
                    Class = "SpeedGame1Controller",
                    GameTime = 1L
                });
                gameMasterTestData.Add(new GameMasterEntity
                {
                    GameId = 6,
                    GameName = "スピードゲーム2",
                    GameTypeId = 2,
                    ScoreType = 1,
                    TitleImage = "detective_game_title",
                    IconImage = "detective_game_icon",
                    Class = "SpeedGame2Controller",
                    GameTime = 2L
                });

                gameMasterTestData.Add(new GameMasterEntity
                {
                    GameId = 7,
                    GameName = "問題解決能力ゲーム1",
                    GameTypeId = 3,
                    ScoreType = 0,
                    TitleImage = "detective_game_title",
                    IconImage = "detective_game_icon",
                    Class = "ComputationalGame1Controller",
                    GameTime = 1L
                });
                gameMasterTestData.Add(new GameMasterEntity
                {
                    GameId = 8,
                    GameName = "問題解決能力ゲーム2",
                    GameTypeId = 3,
                    ScoreType = 1,
                    TitleImage = "detective_game_title",
                    IconImage = "detective_game_icon",
                    Class = "ComputationalGame2Controller",
                    GameTime = 2L
                });
                gameMasterTestData.Add(new GameMasterEntity
                {
                    GameId = 9,
                    GameName = "問題解決能力ゲーム3",
                    GameTypeId = 3,
                    ScoreType = 0,
                    TitleImage = "detective_game_title",
                    IconImage = "detective_game_icon",
                    Class = "ComputationalGame3Controller",
                    GameTime = 3L
                });

                scoreTestData.Add(new ScoreEntity { GameId = 0, Score = 100, RegistDate = DateTime.Now.AddDays(1) });
                scoreTestData.Add(new ScoreEntity { GameId = 0, Score = 200, RegistDate = DateTime.Now.AddDays(2) });
                scoreTestData.Add(new ScoreEntity { GameId = 0, Score = 30000, RegistDate = DateTime.Now.AddDays(3) });
                scoreTestData.Add(new ScoreEntity { GameId = 1, Score = 100, RegistDate = DateTime.Now.AddDays(-1) });
                scoreTestData.Add(new ScoreEntity { GameId = 1, Score = 200, RegistDate = DateTime.Now.AddDays(-2) });
                scoreTestData.Add(new ScoreEntity { GameId = 1, Score = 300, RegistDate = DateTime.Now.AddDays(-3) });
                scoreTestData.Add(new ScoreEntity { GameId = 2, Score = 500, RegistDate = DateTime.Now.AddDays(4) });
                scoreTestData.Add(new ScoreEntity { GameId = 2, Score = 600, RegistDate = DateTime.Now.AddDays(5) });

                helpMasterTestData.Add(new HelpMasterEntity { GameId = 0, Explain = "ゲームの説明1", HelpIndex = 0, Image = "help_image01" });
                helpMasterTestData.Add(new HelpMasterEntity { GameId = 0, Explain = "ゲームの説明2", HelpIndex = 1, Image = "help_image02" });
                helpMasterTestData.Add(new HelpMasterEntity { GameId = 0, Explain = "ゲームの説明3", HelpIndex = 2, Image = "help_image03" });
                helpMasterTestData.Add(new HelpMasterEntity { GameId = 1, Explain = "ゲームの説明1", HelpIndex = 0, Image = "hlep_image01" });
                helpMasterTestData.Add(new HelpMasterEntity { GameId = 1, Explain = "ゲームの説明2", HelpIndex = 1, Image = "help_image02" });
                helpMasterTestData.Add(new HelpMasterEntity { GameId = 2, Explain = "ゲームの説明1", HelpIndex = 0, Image = "help_image01" });
                helpMasterTestData.Add(new HelpMasterEntity { GameId = 2, Explain = "ゲームの説明2", HelpIndex = 1, Image = "help_image02" });
                helpMasterTestData.Add(new HelpMasterEntity { GameId = 3, Explain = "ゲームの説明1", HelpIndex = 0, Image = "help_image01" });
                helpMasterTestData.Add(new HelpMasterEntity { GameId = 3, Explain = "ゲームの説明2", HelpIndex = 1, Image = "help_image02" });
                helpMasterTestData.Add(new HelpMasterEntity { GameId = 3, Explain = "ゲームの説明3", HelpIndex = 2, Image = "help_image03" });
                helpMasterTestData.Add(new HelpMasterEntity { GameId = 3, Explain = "ゲームの説明4", HelpIndex = 3, Image = "help_image04" });
                helpMasterTestData.Add(new HelpMasterEntity { GameId = 3, Explain = "ゲームの説明5", HelpIndex = 4, Image = "help_image05" });

                gameTypeMasterTestData.ForEach(data => con.Insert(data));
                gameMasterTestData.ForEach(data => con.Insert(data));
                helpMasterTestData.ForEach(data => con.Insert(data));
                scoreTestData.ForEach(data => con.Insert(data));
            }
        }
    }
}