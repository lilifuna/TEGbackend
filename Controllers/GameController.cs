using System;
using Microsoft.AspNetCore.Mvc;

namespace TEG.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {

        //POST api/game/game1
        [HttpPost("{name}")]
        public void NewGame(String name) //Or maybe it's better to create a new game by sending full JSON created on the client-side?
        {
            IGameDataProvider dataProvider = new GameDatabaseHelper();

            dataProvider.CreateNewGame(name);
        }

        //POST api/game/
        public void UpdateGameState([FromBody] String gameState)  
        {
            
        }
    }
}