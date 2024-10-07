namespace KafkaConsumerSample.API.Controllers
{
    [ApiVersion("1.0", Deprecated = false)]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        #region Properties

        private readonly IMessageService _messageService;

        #endregion

        #region Constructors

        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }
        #endregion

        #region CRUD Methods

        /// <summary>  Get All Messages </summary>
        [HttpGet]
        [Consumes("application/json")]
        [Produces("application/json")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _messageService.GetAllMessagesAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        #endregion
    }
}
