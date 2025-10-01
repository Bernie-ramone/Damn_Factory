using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData
                (
                    new Employee
                    {
                        Id = Guid.Parse("80abbca8-664d-4b20-b5de-024705497d4a"),
                        Name = "Kane Williamson",
                        Age = 33,
                        Position = "Developer",
                        CompanyId = Guid.Parse("c9d4c053-49b6-410c-bc78-2d54a9991870")
                    },
                    new Employee
                    {
                        Id = Guid.Parse("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                        Name = "Virat Kohli",
                        Age = 34,
                        Position = "Senior Developer",
                        CompanyId = Guid.Parse("c9d4c053-49b6-410c-bc78-2d54a9991870")
                    },
                    new Employee
                    {
                        Id = Guid.Parse("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                        Name = "Rohit Sharma",
                        Age = 36,
                        Position = "Project Manager",
                        CompanyId = Guid.Parse("3d490a70-94ce-4d15-9494-5248280c2ce3")
                    }
                );
        }
    }
}
