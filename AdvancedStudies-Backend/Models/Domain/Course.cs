using AdvancedStudies_Backend.Extensions;
using System.ComponentModel.DataAnnotations;

namespace AdvancedStudies_Backend.Models.Domain
{
    public class Course
    {
        public Course(string title, string description, int price, string imageUrl)
        {
            Title = title;
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
            UrlSlug = Title.Slugify();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string UrlSlug { get; set; }
        public DateTime? PublishedAt { get; set; }
    }
}
