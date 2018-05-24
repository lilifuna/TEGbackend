using System;
using System.Collections.Generic;
using System.Linq;
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
            List<Game> result = new List<Game>();
            using (var context = new GameDBContext())
            {
                result = context.games.ToList();
            }

            return result;       
        }

        public Game GetGameById(int gameID)
        {
            Game result = null;
            using (var context = new GameDBContext())
            {
                result = context.games.Find(gameID);
            }

            return result;
        }

        public List<Game> GetGamesOfPlayer(string playerID)   //currently not possible due to players being stored in JSON as a field of Game object
        {
            throw new NotImplementedException();
        }

        public int CreateNewGame(string name)
        {
            int gameID = 0;
            Game temp = new Game();
            temp.GameName = name;

            using (var context = new GameDBContext())
            {
                gameID = context.games.Add(temp).Entity.GameId;
                context.SaveChanges();
            }
              
            return gameID;
        }


        public void UpdateGame(Game newGameState)
        {
            using (var context = new GameDBContext())
            {
                Game game = context.games.Find(newGameState.GameId);
                if (game != null)
                {
                    game.Copy(newGameState);
                    context.games.Update(game);
                    context.SaveChanges();
                }
            }
        }
         


        public static GameDatabaseHelper GetInstance()
        {
            if(instance == null) instance = new GameDatabaseHelper();
            return instance;
        }
    }
}