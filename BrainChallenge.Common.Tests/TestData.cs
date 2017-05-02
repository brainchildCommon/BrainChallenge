using System.Collections.Generic;
using BrainChallenge.Common.Data.Entity.Master;
using BrainChallenge.Common.Data.Entity.General;
using BrainChallenge.Common.Data.Connection;
using System;

namespace BrainChallenge.Common.Tests
{
    public static class TestData
    {
        public static List<GameMasterEntity> GameMasterTestData = new List<GameMasterEntity>();
        public static List<GameTypeMasterEntity> GameTypeMasterTestData = new List<GameTypeMasterEntity>();
        public static List<HelpMasterEntity> HelpMasterTestData = new List<HelpMasterEntity>();
        public static List<ScoreEntity> ScoreTestData = new List<ScoreEntity>();

        //テスト
        public static List<SampleEntity> SampleTestData = new List<SampleEntity>();

        static TestData()
        {

            GameTypeMasterTestData.Add(new GameTypeMasterEntity { GameTypeId = 0, Name = "記憶力" });
            GameTypeMasterTestData.Add(new GameTypeMasterEntity { GameTypeId = 1, Name = "柔軟性" });
            GameTypeMasterTestData.Add(new GameTypeMasterEntity { GameTypeId = 2, Name = "スピード" });
            GameTypeMasterTestData.Add(new GameTypeMasterEntity { GameTypeId = 3, Name = "問題解決能力" });

            GameMasterTestData.Add(new GameMasterEntity { GameId = 0, GameName = "迷子を探せ!!", GameTypeId = 0, ScoreType = 0, TitleImage = "detective_game_title", IconImage = "detective_game_icon", Class = "DetectiveGameController", GameTime = 1L });
            GameMasterTestData.Add(new GameMasterEntity { GameId = 1, GameName = "記憶力ゲーム2", GameTypeId = 0, ScoreType = 1, TitleImage = "memory2_game_title", IconImage = "memory2_game_icon", Class = "MemoryGame2Controller", GameTime = 2L });
            GameMasterTestData.Add(new GameMasterEntity { GameId = 2, GameName = "記憶力ゲーム3", GameTypeId = 0, ScoreType = 0, TitleImage = "memory3_game_title", IconImage = "memory3_game_icon", Class = "MemoryGame3Controller", GameTime = 3L });
            GameMasterTestData.Add(new GameMasterEntity { GameId = 3, GameName = "記憶力ゲーム4", GameTypeId = 0, ScoreType = 1, TitleImage = "memory4_game_title", IconImage = "memory4_game_icon", Class = "MemoryGame4Controller", GameTime = 4L });

            GameMasterTestData.Add(new GameMasterEntity { GameId = 4, GameName = "柔軟性ゲーム1", GameTypeId = 1, ScoreType = 0, TitleImage = "flexibility1_game_title", IconImage = "flexibility1_game_icon", Class = "FlexibilityGame1Controller", GameTime = 1L });
            //GameMasterTestData.Add(new GameMasterEntity { GameId = 11, GameName = "柔軟性ゲーム2", GameTypeId = 1, ScoreType = 1, TitleImage = "flexibility2_game_title", IconImage = "flexibility2_game_icon", Class = "FlexibilityGame2Controller", GameTime = 2L });
            //GameMasterTestData.Add(new GameMasterEntity { GameId = 12, GameName = "柔軟性ゲーム3", GameTypeId = 1, ScoreType = 0, TitleImage = "flexibility3_game_title", IconImage = "flexibility3_game_icon", Class = "FlexibilityGame3Controller", GameTime = 3L });
            //GameMasterTestData.Add(new GameMasterEntity { GameId = 13, GameName = "柔軟性ゲーム4", GameTypeId = 1, ScoreType = 1, TitleImage = "flexibility4_game_title", IconImage = "flexibility4_game_icon", Class = "FlexibilityGame4Controller", GameTime = 4L });

            GameMasterTestData.Add(new GameMasterEntity { GameId = 5, GameName = "スピードゲーム1", GameTypeId = 2, ScoreType = 0, TitleImage = "speed1_game_title", IconImage = "speed1_game_icon", Class = "SpeedGame1Controller", GameTime = 1L });
            GameMasterTestData.Add(new GameMasterEntity { GameId = 6, GameName = "スピードゲーム2", GameTypeId = 2, ScoreType = 1, TitleImage = "speed2_game_title", IconImage = "speed2_game_icon", Class = "SpeedGame2Controller", GameTime = 2L });
            //GameMasterTestData.Add(new GameMasterEntity { GameId = 14, GameName = "スピードゲーム3", GameTypeId = 2, ScoreType = 0, TitleImage = "speed3_game_title", IconImage = "speed3_game_icon", Class = "SpeedGame3Controller", GameTime = 3L });
            //GameMasterTestData.Add(new GameMasterEntity { GameId = 15, GameName = "スピードゲーム4", GameTypeId = 2, ScoreType = 1, TitleImage = "speed4_game_title", IconImage = "speed4_game_icon", Class = "SpeedGame4Controller", GameTime = 4L });

            GameMasterTestData.Add(new GameMasterEntity { GameId = 7, GameName = "問題解決能力ゲーム1", GameTypeId = 3, ScoreType = 0, TitleImage = "computational1_game_title", IconImage = "computational1_game_icon", Class = "ComputationalGame1Controller", GameTime = 1L });
            GameMasterTestData.Add(new GameMasterEntity { GameId = 8, GameName = "問題解決能力ゲーム2", GameTypeId = 3, ScoreType = 1, TitleImage = "computational2_game_title", IconImage = "computational2_game_icon", Class = "ComputationalGame2Controller", GameTime = 2L });
            GameMasterTestData.Add(new GameMasterEntity { GameId = 9, GameName = "問題解決能力ゲーム3", GameTypeId = 3, ScoreType = 0, TitleImage = "computational3_game_title", IconImage = "computational3_game_icon", Class = "ComputationalGame3Controller", GameTime = 3L });
            //GameMasterTestData.Add(new GameMasterEntity { GameId = 10, GameName = "問題解決能力ゲーム4", GameTypeId = 3, ScoreType = 1, TitleImage = "computational4_game_title", IconImage = "computational4_game_icon", Class = "ComputationalGame4Controller", GameTime = 4L });

            HelpMasterTestData.Add(new HelpMasterEntity { GameId = 0, Explain = "ゲームの説明1", HelpIndex = 0, Image = "help_image01" });
            HelpMasterTestData.Add(new HelpMasterEntity { GameId = 0, Explain = "ゲームの説明2", HelpIndex = 1, Image = "help_image02" });
            HelpMasterTestData.Add(new HelpMasterEntity { GameId = 0, Explain = "ゲームの説明3", HelpIndex = 2, Image = "help_image03" });
            HelpMasterTestData.Add(new HelpMasterEntity { GameId = 1, Explain = "ゲームの説明1", HelpIndex = 0, Image = "hlep_image01" });
            HelpMasterTestData.Add(new HelpMasterEntity { GameId = 1, Explain = "ゲームの説明2", HelpIndex = 1, Image = "help_image02" });
            HelpMasterTestData.Add(new HelpMasterEntity { GameId = 2, Explain = "ゲームの説明1", HelpIndex = 0, Image = "help_image01" });
            HelpMasterTestData.Add(new HelpMasterEntity { GameId = 2, Explain = "ゲームの説明2", HelpIndex = 1, Image = "help_image02" });
            HelpMasterTestData.Add(new HelpMasterEntity { GameId = 3, Explain = "ゲームの説明1", HelpIndex = 0, Image = "help_image01" });
            HelpMasterTestData.Add(new HelpMasterEntity { GameId = 3, Explain = "ゲームの説明2", HelpIndex = 1, Image = "help_image02" });
            HelpMasterTestData.Add(new HelpMasterEntity { GameId = 3, Explain = "ゲームの説明3", HelpIndex = 2, Image = "help_image03" });
            HelpMasterTestData.Add(new HelpMasterEntity { GameId = 3, Explain = "ゲームの説明4", HelpIndex = 3, Image = "help_image04" });
            HelpMasterTestData.Add(new HelpMasterEntity { GameId = 3, Explain = "ゲームの説明5", HelpIndex = 4, Image = "help_image05" });

            ScoreTestData.Add(new ScoreEntity { GameId = 0, Score = 100, RegistDate = DateTime.Now.AddDays(1) });
            ScoreTestData.Add(new ScoreEntity { GameId = 0, Score = 200, RegistDate = DateTime.Now.AddDays(2) });
            ScoreTestData.Add(new ScoreEntity { GameId = 0, Score = 300, RegistDate = DateTime.Now.AddDays(3) });
            ScoreTestData.Add(new ScoreEntity { GameId = 1, Score = 100, RegistDate = DateTime.Now.AddDays(-1) });
            ScoreTestData.Add(new ScoreEntity { GameId = 1, Score = 200, RegistDate = DateTime.Now.AddDays(-2) });
            ScoreTestData.Add(new ScoreEntity { GameId = 1, Score = 300, RegistDate = DateTime.Now.AddDays(-3) });
            ScoreTestData.Add(new ScoreEntity { GameId = 2, Score = 500, RegistDate = DateTime.Now.AddDays(4) });
            ScoreTestData.Add(new ScoreEntity { GameId = 2, Score = 600, RegistDate = DateTime.Now.AddDays(5) });

            SampleTestData.Add(new SampleEntity { Id = 0, Name = "テスト0" });
            SampleTestData.Add(new SampleEntity { Id = 1, Name = "テスト1" });
            SampleTestData.Add(new SampleEntity { Id = 2, Name = "テスト2" });
            SampleTestData.Add(new SampleEntity { Id = 3, Name = "テスト3" });

        }

        private static void LoadingData()
        {
            using (var con = ConnectionProvider.GetConnection())
            {

                GameTypeMasterTestData.ForEach(data => con.Insert(data));
                GameMasterTestData.ForEach(data => con.Insert(data));
                HelpMasterTestData.ForEach(data => con.Insert(data));
                ScoreTestData.ForEach(data => con.Insert(data));

                SampleTestData.ForEach(data => con.Insert(data));

            }
        }

        public static void InitDataBase()
        {
            var dbPath = GetLocalFilePath("brainchallenge.db3");
            ConnectionProvider.DbPath = dbPath;

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
                    Console.WriteLine(e);
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

        private static string GetLocalFilePath(string filename)
        {
            //指定されたファイルのパスを取得します。なければ作成してそのパスを返却します
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, filename);
        }

    }
}