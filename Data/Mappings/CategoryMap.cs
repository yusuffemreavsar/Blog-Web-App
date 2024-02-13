using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("7D2AAE5F-547F-49EE-8FF4-15046C4F8CD8"),
                Name = "Asp.net Core",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                isDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("942F9F84-6156-40C5-ADB0-93970F70E720"),
                Name = "Spring Boot",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                isDeleted = false
            },
             new Category
             {
                 Id = Guid.Parse("2ED3EC85-5FC6-43D9-B2A3-19F8523B9EAE"),
                 Name = "Node.Js",
                 CreatedBy = "Admin",
                 CreatedDate = DateTime.Now,
                 isDeleted = false
             }
            );
        }
    }
}
