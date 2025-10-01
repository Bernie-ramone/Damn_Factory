using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData
                (
                    new Company
                    {
                        Id = Guid.Parse("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                        Name = "Google",
                        Address = "1600 Amphitheatre Parkway, Mountain View, CA 94043",
                        Country = "USA"
                    },
                    new Company
                    {
                        Id = Guid.Parse("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                        Name = "Microsoft",
                        Address = "One Microsoft Way, Redmond, WA 98052",
                        Country = "USA"
                    }
                );
        }
    }
}
