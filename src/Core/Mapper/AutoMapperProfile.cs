namespace KafkaConsumerSample.Core.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Message, MessageDTO>().ReverseMap();
        }
    }
}
