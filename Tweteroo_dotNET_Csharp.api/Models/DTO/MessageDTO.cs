using System.ComponentModel.DataAnnotations;

namespace Tweteroo_dotNET_Csharp.Models.DTO
{
    public class MessageDTO
    {
        [Required(ErrorMessage = "Mensagem Obrigatória")]
        public string Titulo { get; set; }
    }
}
