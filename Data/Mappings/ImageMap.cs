using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("8F770E4D-85E5-4C28-9DD3-2CA7B30C8D8D"),
                FileName = "images/testimage_1",
                FileType = "jpg",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                isDeleted = false
            },
             new Image
             {
                 Id = Guid.Parse("DDD58D89-C5B1-4CE6-89D4-DE833E22CD06"),
                 FileName = "images/testimage_2",
                 FileType = "jpg",
                 CreatedBy = "Admin",
                 CreatedDate = DateTime.Now,
                 isDeleted = false
             },
              new Image
              {
                  Id = Guid.Parse("B0AB9960-DCF0-49CA-A313-DA0F42E5E1C5"),
                  FileName = "images/testimage_3",
                  FileType = "jpg",
                  CreatedBy = "Admin",
                  CreatedDate = DateTime.Now,
                  isDeleted = false
              }
            );
        }
    }
}
