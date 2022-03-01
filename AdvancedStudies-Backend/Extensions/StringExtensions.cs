namespace AdvancedStudies_Backend.Extensions
{
    public static class StringExtensions
    {
        public static string Slugify(this string name) => name.Trim()
          .Replace("-", "")
          .Replace(" ", "-")
          .ToLower();
    }
}
