using System.ComponentModel.DataAnnotations;

namespace AdvancedStudies_Backend.Models.DTO
{
    public class CreateCourseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string UrlSlug { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
