using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TEG.Models;

namespace TEG
{
    public  class GameDatabaseHelper : IGameDataProvider
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


        public void AddNewUser(String username)
        {
            using (var context = new GameDBContext())
            {
                User user = new User();
                user.Username = username;

                context.users.Add(user);
                context.SaveChanges();
            }
        }

        public User GetUser(String username)
        {
            User result = null;
            using (var context = new GameDBContext())
            {
                result = context.users
                    .Single(b => b.Username == username);
            }

            return result;
        }


        public ICollection<Game> GetGamesOfUser(String username)
        {
            List<Game> result = new List<Game>();

            using (var context = new GameDBContext())
            {
                User user = context.users
                    .Single(u => u.Username == username);
                
                result = context.gamesOfUsers
                    .Where(gou => gou.PlayerId == user.UserId)
                    .Select(x => x.Game)
                    .ToList();
            }

            return result;
        }
        
        

        public static GameDatabaseHelper GetInstance()
        {
            if(instance == null) instance = new GameDatabaseHelper();
            return instance;
        }
        
      
    }
}