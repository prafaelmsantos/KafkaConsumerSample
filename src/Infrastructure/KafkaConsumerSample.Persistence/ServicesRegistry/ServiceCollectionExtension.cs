namespace KafkaConsumerSample.Persistence.ServicesRegistry
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            #region Repositories
            services.AddScoped<IMessageRepository, MessageRepository>();
            #endregion

            #region Services
            services.AddScoped<IMessageService, MessageService>();
            #endregion

            return services;
        }
    }
}
