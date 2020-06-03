using System.ComponentModel.DataAnnotations;

namespace Mart.API.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
