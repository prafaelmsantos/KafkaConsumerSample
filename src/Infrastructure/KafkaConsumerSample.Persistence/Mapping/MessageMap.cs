namespace KafkaConsumerSample.Persistence.Mapping
{
    public class MessageMap : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> entity)
        {
            entity.ToTable("messages");

            entity.HasKey(x => x.Id);

            entity.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .IsRequired(true);

            entity.Property(x => x.Content)
                .HasColumnName("content")
                .IsRequired(true);

            entity.Property(x => x.ExternalId)
                .HasColumnName("external_id")
                .IsRequired(true);
        }
    }
}
