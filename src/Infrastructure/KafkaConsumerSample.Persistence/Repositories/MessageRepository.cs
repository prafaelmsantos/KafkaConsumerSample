namespace KafkaConsumerSample.Persistence.Repositories
{
    public class MessageRepository(AppDbContext context) : Repository<Message>(context), IMessageRepository
    {
    }
}
