using NekoBotV1.DataBase;

namespace NekoBotAPI.Models
{
    public class ImageResult
    {
        public bool IsSuccessful { get; private set; } = false;

        public string PublicUrl { get; private set; } = string.Empty;
        public string Category { get; private set; } = string.Empty;

        public static ImageResult FromSuccess(string publicUrl, ImageCategory category)
            => new()
            {
                IsSuccessful = true,
                PublicUrl = publicUrl,
                Category = category.ToString()
            };

        public static ImageResult FromEmpty()
            => new()
            {
                IsSuccessful = false
            };
    }
}
