using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.Language;
using TEG.Models;

namespace TEG
{
    public class MockGameDataProvider : IGameDataProvider    //For development puroposes - mock data without using the database
    {
        private List<Game> games;

        private static MockGameDataProvider instance;

        private MockGameDataProvider()
        {
            GenerateMockGames();
        }

        private void GenerateMockGames()
        {
            for (int i = 0; i < 10; i++)
            {
                Game temp = new Game();
                temp.GameId = i;
                temp.GameName = "Game: " + i;
                temp.Lanes = " "; // TODO: JSON lanes compatible with frontend
                temp.ModeratorUserId = 0.ToString();
                temp.PlayersIds = "\"players\" : [\"1\",\"2\"]";
                temp.Agreed = "\"agreed\" : [\"1\",\"0\"]";
                games.Add(temp);
            }
        }

        public List<Game> GetAllGames()
        {
            return games;
        }

        public Game GetGameById(int gameID)
        {
            return games[gameID];
        }

        public List<Game> GetGamesOfPlayer(string playerID)
        {
            throw new System.NotImplementedException();
        }

        public int CreateNewGame(string name)
        {
            Game temp = new Game();
            temp.GameName = name;
            games.Add(temp);
       
            return games.IndexOf(temp);
        }

        public void UpdateGame(Game newGameState)
        {
            throw new NotImplementedException();
        }


        public static MockGameDataProvider GetInstance()
        {
            if(instance == null) instance = new MockGameDataProvider();
            return instance;
        }
    }
}