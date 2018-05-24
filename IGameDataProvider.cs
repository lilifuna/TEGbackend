using System;
using System.Collections.Generic;
using TEG.Models;

namespace TEG
{
    public interface IGameDataProvider
    {
        
        List<Game> GetAllGames();
        Game GetGameById(int gameID);
        List<Game> GetGamesOfPlayer(String playerID);
        int CreateNewGame(String name);
        void UpdateGame(Game gameState);


    }
}