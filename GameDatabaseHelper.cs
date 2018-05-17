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

        public bool CreateNewGame(string name)
        {
            throw new System.NotImplementedException();
        }

        
    }
}