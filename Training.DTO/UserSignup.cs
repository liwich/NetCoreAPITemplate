using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Training.DTO
{
    public class UserSignup : User
    {
        [JsonProperty("password")]
        [RegularExpression(".*[0-9].*", ErrorMessage = "Password must contain at least 1 numeric character")]
        public string Password { get; set; }
    }
}
