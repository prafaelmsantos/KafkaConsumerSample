namespace KafkaConsumerSample.Persistence.Services
{
    public class MessageService : IMessageService
    {
        #region Private variables

        private readonly IMapper _mapper;
        private readonly IMessageRepository _messageRepository;

        #endregion

        #region Constructors
        public MessageService(IMapper mapper, IMessageRepository messageRepository)
        {
            _mapper = mapper;
            _messageRepository = messageRepository;
        }
        #endregion

        #region Public methods

        public async Task<List<MessageDTO>> GetAllMessagesAsync()
        {
            try
            {
                List<Message> messages = await _messageRepository
                    .GetAll()
                    .OrderBy(x => x.Id)
                    .AsNoTracking()
                    .ToListAsync();

                return _mapper.Map<List<MessageDTO>>(messages);
            }
            catch (Exception ex)
            {
                throw new Exception($"{DomainResources.GetAllMessagesAsyncException} {ex.Message}");
            }
        }
        #endregion
    }
}
