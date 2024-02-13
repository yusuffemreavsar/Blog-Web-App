using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            _ = builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Example",
                Content = "About Asp.net Core...",
                ViewCount = 15,
                CategoryId = Guid.Parse("7D2AAE5F-547F-49EE-8FF4-15046C4F8CD8"),
                ImageId = Guid.Parse("8F770E4D-85E5-4C28-9DD3-2CA7B30C8D8D"),
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Spring Boot Example",
                Content = "About Spring Boot...",
                ViewCount = 10,
                CategoryId = Guid.Parse("942F9F84-6156-40C5-ADB0-93970F70E720"),
                ImageId = Guid.Parse("DDD58D89-C5B1-4CE6-89D4-DE833E22CD06"),
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Node.Js Example",
                Content = "About Node.Js...",
                ViewCount = 24,
                CategoryId = Guid.Parse("2ED3EC85-5FC6-43D9-B2A3-19F8523B9EAE"),
                ImageId = Guid.Parse("B0AB9960-DCF0-49CA-A313-DA0F42E5E1C5"),
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
            }
            );
        }
    }
}
