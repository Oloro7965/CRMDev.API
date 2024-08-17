using CRMDev.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Infraestructure.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Opportunities).
                WithOne(x => x.contact).
                HasForeignKey(x => x.ContactId).
                OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Notes).
                WithOne(x => x.contact).
                HasForeignKey(x => x.ContactId).
                OnDelete(DeleteBehavior.Restrict);

        }
    }
}
