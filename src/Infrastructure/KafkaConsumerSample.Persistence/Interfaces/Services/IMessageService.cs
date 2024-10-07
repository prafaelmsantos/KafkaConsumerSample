namespace KafkaConsumerSample.Persistence.Interfaces.Services
{
    public interface IMessageService
    {
        Task<List<MessageDTO>> GetAllMessagesAsync();
    }
}
