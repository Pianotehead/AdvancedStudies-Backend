using System.ComponentModel.DataAnnotations;

namespace AdvancedStudies_Backend.Models.DTO
{
    public class CreateCourseDto
    {
        public string Title { get; set; }
        [MaxLength(120)]
        public string SubTitle { get; set; }
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        [MaxLength(1000)]
        public string WelcomeMessage { get; set; }
        [MaxLength(1000)]
        public string CongratulationsMessage { get; set; }
    }
}
