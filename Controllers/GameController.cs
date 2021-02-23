using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesController : ControllerBase
    {
        public static List<Games> GetGames()
        {
            List<Games> games = new List<Games>();
            games.Add(new Games() { ID = 1, Name = "Game 1", Price = 10 });
            games.Add(new Games() { ID = 2, Name = "Game 1", Price = 15 });
            games.Add(new Games() { ID = 3, Name = "Game 1", Price = 20 });
            games.Add(new Games() { ID = 4, Name = "Game 1", Price = 25 });
            games.Add(new Games() { ID = 5, Name = "Game 1", Price = 30 });

            return games;
        }

        [HttpGet]
        public IEnumerable<Games> GetGames_List()
        {
            return GetGames();
        }

        [HttpGet("{id}")]
        public ActionResult<Games> GetGames_ByID(int ID)
        {
            var game = GetGames().Find(x => x.ID == ID);
            if (game != null)
                return game;
            return NotFound();
        }
    }
}