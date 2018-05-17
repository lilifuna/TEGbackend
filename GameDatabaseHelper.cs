using System.Collections.Generic;
using TEG.Models;

namespace TEG
{
    public class GameDatabaseHelper : IGameDataProvider
    {
       
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

        
    }
}