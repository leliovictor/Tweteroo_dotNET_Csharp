using Microsoft.AspNetCore.Mvc;

using Tweteroo_dotNET_Csharp.Models;
using Tweteroo_dotNET_Csharp.Service;

namespace Tweteroo_dotNET_Csharp.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TweetsController : ControllerBase
    {
        private static List<Tweet> tweets = new List<Tweet>();
        private static int id = 0;

        [HttpGet]
        public IActionResult RecuperarTweets([FromQuery] int page=1)
        {

            Console.WriteLine(page);

            if (page < 1)
            {
                return BadRequest("Informe uma página válida");
            }

            int limite = 10;
            int start = (page - 1) * limite;
            int end = page * limite;

            if(tweets.Count <= 10)
            {

                return Ok(TweetService.ReverseTweets(tweets));
            }

            List<Tweet> reverseTweets = TweetService.ReverseTweets(tweets);
            return Ok(reverseTweets.GetRange(start,end));
        }

        [HttpPost]
        public IActionResult PostarTweet([FromBody] Tweet tweet)
        {
            User? user = UsersController.RecuperaUsuario(tweet.Username);

            if (user == null)
            {
                return BadRequest("Usuário Inexistente");
            }

            tweet.Avatar = user.Avatar;
            tweets.Add(tweet);
            tweet.Id = id++;
            return Created("", "OK, seu tweet foi criado");
        }

        [HttpGet("{username}")]
        public IActionResult RecuperaTweetPorId(string username)
        {
            List<Tweet> tweetsUsuario = tweets.FindAll(t => t.Username == username);

            return Ok(tweetsUsuario);
        }
    }
}
