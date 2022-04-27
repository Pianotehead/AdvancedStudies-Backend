using AdvancedStudies_Backend.Models.Domain;

namespace AdvancedStudies_Backend.Extensions
{
    public static class CourseExtensions
    {
        public static IQueryable<Course> Search(this IQueryable<Course> query, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm)) return query;
            var lowercaseSearchTerm = searchTerm.Trim().ToLower();

            return query.Where(c => c.Title.ToLower().Contains(lowercaseSearchTerm));
        }
    }
}