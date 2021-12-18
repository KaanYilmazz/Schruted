using System.ComponentModel.DataAnnotations;

namespace Schruted.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}