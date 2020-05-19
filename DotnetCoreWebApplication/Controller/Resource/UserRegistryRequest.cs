using System.ComponentModel.DataAnnotations;

namespace DotnetCoreWebApplication.Controller.Resource
{
    public class UserRegistryRequest
    {
        [Required]
        public string NickName { get; set; }
        public string Name { get; set; }
    }
    
}