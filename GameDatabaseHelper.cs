using System.Collections.Generic;
using TEG.Models;

namespace TEG
{
    public sealed class GameDatabaseHelper : IGameDataProvider
    {

        private static GameDatabaseHelper instance;
        
        private GameDatabaseHelper()
        {
            
        }
        
        public List<Game> GetAllGames()
        {
            throw new System.NotImplementedException();
        }

        public Game GetGameById(string gameID)
        {
            throw new System.NotImplementedException();
        }

        public List<Game> GetGamesOfPlayer(string playerID)
        {
            throw new System.NotImplementedException();
        }

        public string CreateNewGame(string name)
        {
            string gameID = null;

                                    //TODO: Database query that returns the newly created game's ID

            return gameID;
        }


        public static GameDatabaseHelper GetInstance()
        {
            if(instance == null) instance = new GameDatabaseHelper();
            return instance;
        }
    }
}