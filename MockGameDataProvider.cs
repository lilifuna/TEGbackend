using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.Language;
using TEG.Models;

namespace TEG
{
    public class MockGameDataProvider : IGameDataProvider    //For development puroposes - mock data without using the database
    {
        private List<Game> games;

        public MockGameDataProvider()
        {
            GenerateMockGames();
        }

        private void GenerateMockGames()
        {
            for (int i = 0; i < 10; i++)
            {
                Game temp = new Game();
                temp.GameId = i.ToString();
                temp.GameName = "Game: " + i;
                temp.Lanes = " "; // TODO: JSON lanes compatible with frontend
                temp.ModeratorUserId = 0.ToString();
                temp.PlayersIds = new List<string>(new string[] {"1", "2", "3"});
                games.Add(temp);
            }
        }

        public List<Game> GetAllGames()
        {
            return new List<Game>();
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
            throw new System.NotImplementedException();
        }
    }
}