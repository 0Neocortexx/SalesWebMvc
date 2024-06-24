using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SalesWebMvc.Models.Mappings {
    public class ProdutoMap : IEntityTypeConfiguration<Produto> 
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(e => e.id);
            builder.Property(e => e.id).ValueGeneratedOnAdd();
            builder.Property(e => e.nome).IsRequired().HasMaxLength(100);
        }
    }
}
