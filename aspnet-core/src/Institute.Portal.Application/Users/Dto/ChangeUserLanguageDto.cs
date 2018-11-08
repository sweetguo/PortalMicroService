using System.ComponentModel.DataAnnotations;

namespace Institute.Portal.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}