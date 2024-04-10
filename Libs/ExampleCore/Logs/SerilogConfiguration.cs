using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Events;


namespace ExampleCore.Logs
{
    /// <summary>
    /// Конфигурации Серилога
    /// </summary>
    public static class SerilogConfiguration
    {
        /// <summary>
        /// Добавление логирования
        /// </summary>
        public static IServiceCollection AddLoggerServices(this IServiceCollection services)
        {
            return services
                .AddSingleton(Log.Logger);
        }

    }
}
