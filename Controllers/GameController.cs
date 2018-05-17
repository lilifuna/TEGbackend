using System;
using Microsoft.AspNetCore.Mvc;

namespace TEG.Controllers
{
    [Route("api/[controller]")]
    public class GameController : Controller
    {


        [HttpPost("{name}")]
        public void NewGame(String name)
        {
            IGameDataProvider dataProvider = new GameDatabaseHelper();

            dataProvider.CreateNewGame(name);
        }
    }
}