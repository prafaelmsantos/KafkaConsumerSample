namespace KafkaConsumerSample.Core.Domain
{
    public class Message : EntityBase
    {
        public string Content { get; private set; } = null!;
        public long ExternalId { get; private set; }

        public Message(string content, long externalId)
        {
            Content = content;
            ExternalId = externalId;
        }
    }
}
