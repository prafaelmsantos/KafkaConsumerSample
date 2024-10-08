namespace KafkaConsumerSample.Consumer.Services
{
    public sealed class MessageConsumer : IKafkaConsumer<MessageContract>
    {
        #region Private variables
        private readonly ILogger<MessageConsumer> _logger;
        private readonly IMessageService _messageService;

        #endregion

        #region Constructors

        public MessageConsumer(ILogger<MessageConsumer> logger, IMessageService messageService)
        {
            _logger = logger;
            _messageService = messageService;
        }
        #endregion

        #region Public methods
        public async Task OnBatchReceivedAsync(IAsyncEnumerable<MessageContract> batch)
        {
            int count = 0;

            await foreach (MessageContract messageContract in batch)
            {
                count++;
                MessageDTO messageDTO = new()
                {
                    Content = messageContract.Content,
                    ExternalId = messageContract.Id
                };
                await _messageService.AddMessageAsync(messageDTO);
            }

            _logger.LogInformation($"Received batch of {count} messages");
        }
        #endregion
    }
}
