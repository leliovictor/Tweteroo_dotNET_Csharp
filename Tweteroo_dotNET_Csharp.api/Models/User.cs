using System.ComponentModel.DataAnnotations;

namespace Tweteroo_dotNET_Csharp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Username obrigatório")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Avatar obrigatório")]
        public string Avatar { get; set; }
    }
}
