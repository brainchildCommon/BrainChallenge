using System.Collections.Generic;
using BrainChallenge.Common.Data.Entity.Master;
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

        static TestData()
        {

            GameTypeMasterTestData.Add(new GameTypeMasterEntity { GameTypeId = 0, Name = "�L����" });
            GameTypeMasterTestData.Add(new GameTypeMasterEntity { GameTypeId = 1, Name = "�_�" });
            GameTypeMasterTestData.Add(new GameTypeMasterEntity { GameTypeId = 2, Name = "�X�s�[�h" });
            GameTypeMasterTestData.Add(new GameTypeMasterEntity { GameTypeId = 3, Name = "�������\��" });

            GameMasterTestData.Add(new GameMasterEntity { GameId = 0, GameName = "���q��T��!!", GameTypeId = 0, ScoreType = 0, TitleImage = "detective_game_title", IconImage = "detective_game_icon", Class = "DetectiveGameController", GameTime = 1L });
            GameMasterTestData.Add(new GameMasterEntity { GameId = 1, GameName = "�L���̓Q�[��2", GameTypeId = 0, ScoreType = 1, TitleImage = "memory2_game_title", IconImage = "memory2_game_icon", Class = "MemoryGame2Controller", GameTime = 2L });
            GameMasterTestData.Add(new GameMasterEntity { GameId = 2, GameName = "�L���̓Q�[��3", GameTypeId = 0, ScoreType = 0, TitleImage = "memory3_game_title", IconImage = "memory3_game_icon", Class = "MemoryGame3Controller", GameTime = 3L });
            GameMasterTestData.Add(new GameMasterEntity { GameId = 3, GameName = "�L���̓Q�[��4", GameTypeId = 0, ScoreType = 1, TitleImage = "memory4_game_title", IconImage = "memory4_game_icon", Class = "MemoryGame4Controller", GameTime = 4L });

            GameMasterTestData.Add(new GameMasterEntity { GameId = 4, GameName = "�_��Q�[��1", GameTypeId = 1, ScoreType = 0, TitleImage = "flexibility1_game_title", IconImage = "flexibility1_game_icon", Class = "FlexibilityGame1Controller", GameTime = 1L });
            //GameMasterTestData.Add(new GameMasterEntity { GameId = 11, GameName = "�_��Q�[��2", GameTypeId = 1, ScoreType = 1, TitleImage = "flexibility2_game_title", IconImage = "flexibility2_game_icon", Class = "FlexibilityGame2Controller", GameTime = 2L });
            //GameMasterTestData.Add(new GameMasterEntity { GameId = 12, GameName = "�_��Q�[��3", GameTypeId = 1, ScoreType = 0, TitleImage = "flexibility3_game_title", IconImage = "flexibility3_game_icon", Class = "FlexibilityGame3Controller", GameTime = 3L });
            //GameMasterTestData.Add(new GameMasterEntity { GameId = 13, GameName = "�_��Q�[��4", GameTypeId = 1, ScoreType = 1, TitleImage = "flexibility4_game_title", IconImage = "flexibility4_game_icon", Class = "FlexibilityGame4Controller", GameTime = 4L });

            GameMasterTestData.Add(new GameMasterEntity { GameId = 5, GameName = "�X�s�[�h�Q�[��1", GameTypeId = 2, ScoreType = 0, TitleImage = "speed1_game_title", IconImage = "speed1_game_icon", Class = "SpeedGame1Controller", GameTime = 1L });
            GameMasterTestData.Add(new GameMasterEntity { GameId = 6, GameName = "�X�s�[�h�Q�[��2", GameTypeId = 2, ScoreType = 1, TitleImage = "speed2_game_title", IconImage = "speed2_game_icon", Class = "SpeedGame2Controller", GameTime = 2L });
            //GameMasterTestData.Add(new GameMasterEntity { GameId = 14, GameName = "�X�s�[�h�Q�[��3", GameTypeId = 2, ScoreType = 0, TitleImage = "speed3_game_title", IconImage = "speed3_game_icon", Class = "SpeedGame3Controller", GameTime = 3L });
            //GameMasterTestData.Add(new GameMasterEntity { GameId = 15, GameName = "�X�s�[�h�Q�[��4", GameTypeId = 2, ScoreType = 1, TitleImage = "speed4_game_title", IconImage = "speed4_game_icon", Class = "SpeedGame4Controller", GameTime = 4L });

            GameMasterTestData.Add(new GameMasterEntity { GameId = 7, GameName = "�������\�̓Q�[��1", GameTypeId = 3, ScoreType = 0, TitleImage = "computational1_game_title", IconImage = "computational1_game_icon", Class = "ComputationalGame1Controller", GameTime = 1L });
            GameMasterTestData.Add(new GameMasterEntity { GameId = 8, GameName = "�������\�̓Q�[��2", GameTypeId = 3, ScoreType = 1, TitleImage = "computational2_game_title", IconImage = "computational2_game_icon", Class = "ComputationalGame2Controller", GameTime = 2L });
            GameMasterTestData.Add(new GameMasterEntity { GameId = 9, GameName = "�������\�̓Q�[��3", GameTypeId = 3, ScoreType = 0, TitleImage = "computational3_game_title", IconImage = "computational3_game_icon", Class = "ComputationalGame3Controller", GameTime = 3L });
            //GameMasterTestData.Add(new GameMasterEntity { GameId = 10, GameName = "�������\�̓Q�[��4", GameTypeId = 3, ScoreType = 1, TitleImage = "computational4_game_title", IconImage = "computational4_game_icon", Class = "ComputationalGame4Controller", GameTime = 4L });

        }

        private static void LoadingData()
        {
            using (var con = ConnectionProvider.getConnection())
            {

                GameTypeMasterTestData.ForEach(data => con.Insert(data));
                GameMasterTestData.ForEach(data => con.Insert(data));

            }
        }

        public static void initDataBase()
        {
            var dbPath = GetLocalFilePath("brainchallenge.db3");
            ConnectionProvider.dbPath = dbPath;

            using (var con = ConnectionProvider.getConnection())
            {

                try
                {
                    //�e�[�u�����폜
                    con.DropTable<GameTypeMasterEntity>();
                    con.DropTable<GameMasterEntity>();
                    con.DropTable<HelpMasterEntity>();
                    con.DropTable<ScoreEntity>();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }


                //�e�[�u�����쐬
                con.CreateTable<GameTypeMasterEntity>();
                con.CreateTable<GameMasterEntity>();
                con.CreateTable<HelpMasterEntity>();
                con.CreateTable<ScoreEntity>();

            }

            LoadingData();

        }

        private static string GetLocalFilePath(string filename)
        {
            //�w�肳�ꂽ�t�@�C���̃p�X���擾���܂��B�Ȃ���΍쐬���Ă��̃p�X��ԋp���܂�
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, filename);
        }

    }
}