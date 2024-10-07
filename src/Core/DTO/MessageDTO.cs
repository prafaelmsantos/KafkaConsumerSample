namespace KafkaConsumerSample.Core.DTO
{
    public class MessageDTO
    {
        public long Id { get; set; }
        public string Content { get; set; } = null!;
        public long ExternalId { get; set; }
    }
}
