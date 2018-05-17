using System;
using System.Collections.Generic;
using TEG.Models;

namespace TEG
{
    public interface IGameDataProvider
    {
        
        List<Game> GetAllGames();
        Game GetGameById(String gameID);
        List<Game> GetGamesOfPlayer(String playerID);
        bool CreateNewGame(String name);

        
    }
}