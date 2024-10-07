namespace KafkaConsumerSample.Core.Domain
{
    public class Message
    {
        public long Id { get; private set; }
        public string Content { get; private set; } = null!;
        public long ExternalId { get; private set; }

        public Message(long id, string content, long externalId)
        {
            Id = id;
            Content = content;
            ExternalId = externalId;
        }
    }
}
