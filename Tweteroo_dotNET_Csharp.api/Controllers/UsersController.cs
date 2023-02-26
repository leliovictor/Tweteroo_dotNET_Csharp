using Microsoft.AspNetCore.Mvc;
using Tweteroo_dotNET_Csharp.Models;

namespace Tweteroo_dotNET_Csharp.Controllers
{

    [ApiController]
    [Route("sign-up")]
    public class UsersController : ControllerBase
    {
        private static List<User> users = new List<User>();
        private static int id = 0;

        public static User? RecuperaUsuario(string username)
        {
            return users.FirstOrDefault(person => person.Username == username);
        }

        [HttpPost]
        public IActionResult AdicionaUsuario([FromBody] User user)
        {
            users.Add(user);
            user.Id = id++;
            return Ok("Deu tudo certo!");
        }

        [HttpGet]
        public IEnumerable<User> RecuperaUsuarios()
        {
            return users; //apenas para checar se funcionou
        }

    }
}
