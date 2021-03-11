using inep.domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inep.repository.configuration
{
    public class EscolaConfiguration : IEntityTypeConfiguration<EscolaEntity>
    {
        public void Configure(EntityTypeBuilder<EscolaEntity> builder)
        {
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();




            //builder.HasData(new EscolaEntity());
        }
    }
}
