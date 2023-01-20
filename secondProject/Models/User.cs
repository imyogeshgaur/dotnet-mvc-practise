using System.ComponentModel.DataAnnotations;
namespace secondProject.Models
{
    
    public class UserModel 
    {
        [Required]
        public string ? firstName {get;set;}
        [Required]
        public string ? lastName {get;set;}
        [Required]
        public string ? middleName {get;set;}
    }
}
