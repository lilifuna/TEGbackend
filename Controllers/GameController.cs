using System;
using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using TEG.Models;

namespace TEG.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {

        private IGameDataProvider dataProvider;
        
        
        //POST api/game/game1
        [HttpPost("{name}")]
        public void NewGame(String name) //Or maybe it's better to create a new game by sending full JSON created on the client-side?
        {
            IGameDataProvider dataProvider = MockGameDataProvider.GetInstance(); // GameDatabaseHelper.GetInstance(); FOR DEVELOPMENT PURPOSES

            dataProvider.CreateNewGame(name);
        }
        
        

        //POST api/game/
        [HttpPost]
        public IActionResult UpdateGameState([FromBody] Game gameState)
        {
            return Json(gameState);
        }
        
        //GET api/game/12345
        [HttpGet("{gameId}")]
        public JsonResult GetGameState(String gameId)
        {
            IGameDataProvider dataProvider = MockGameDataProvider.GetInstance(); // GameDatabaseHelper.GetInstance();
            return Json(dataProvider.GetGameById(gameId));
        }
        
        //GET api/game/
        [HttpGet]
        public JsonResult GetAllGames()
        {
            IGameDataProvider dataProvider = MockGameDataProvider.GetInstance(); // GameDatabaseHelper.GetInstance();
            return Json(dataProvider.GetAllGames());
        }
    }
}