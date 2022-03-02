using System.ComponentModel.DataAnnotations;

namespace AdvancedStudies_Backend.Models.DTO
{
    public class UpdateCourseDto
    {
        [Required]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
