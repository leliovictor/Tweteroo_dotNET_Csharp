using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Tweteroo_dotNET_Csharp.Models
{
    public class Tweet
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Todos os campos são obrigatórios!")]
        public string Username { get; set; }

        [ValidateNever]
        public string Avatar { get; set; }

        [Required(ErrorMessage = "Todos os campos são obrigatórios!")]
        public string tweet { get; set; }

        public List<Tweet> ReverseTweets(List<Tweet> twts)
        {
            List<Tweet> cloneTwts = new List<Tweet>(twts);
            cloneTwts.Reverse();
            return cloneTwts;
        }
    }
}
