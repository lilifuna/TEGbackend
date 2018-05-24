using System;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using TEG.Models;

namespace TEG.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {

        private IGameDataProvider dataProvider =  GameDatabaseHelper.GetInstance();
        
        
        //POST api/game/game1
        [HttpPost("{name}")]
        public void NewGame(String name) //Or maybe it's better to create a new game by sending full JSON created on the client-side?
        {      
            dataProvider.CreateNewGame(name);
        }
        
        

        //POST api/game/
        [HttpPost]
        public async Task UpdateGameState([FromBody] Game gameState)
        {
            dataProvider.UpdateGame(gameState);
        }
        
        //GET api/game/12345
        [HttpGet("{gameId}")]
        public JsonResult GetGameState(int gameId)
        {
            return Json(dataProvider.GetGameById(gameId));
        }
        
        //GET api/game/
        [HttpGet]
        public JsonResult GetAllGames()
        {
            return Json(dataProvider.GetAllGames());
        }
        
        
    }
}