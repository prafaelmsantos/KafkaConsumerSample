namespace KafkaConsumerSample.Consumer.ServicesRegistry
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddConsumerServices(this IServiceCollection services)
        {
            #region Services
            services.ConfigureSilverback().AddScopedSubscriber<MessageConsumer>();
            #endregion

            return services;
        }
    }
}
