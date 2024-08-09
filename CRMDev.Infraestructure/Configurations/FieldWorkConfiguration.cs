using CRMDev.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Infraestructure.Configurations
{
    public class FieldWorkConfiguration : IEntityTypeConfiguration<FieldWork>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<FieldWork> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
