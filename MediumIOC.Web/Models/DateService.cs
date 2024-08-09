
namespace MediumIOC.Web.Models
{
    public class DateService : ISingletonDateService, IScoopedDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;
        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;
            logger.LogWarning("DataService constructor'ına girdi");
        }
        public DateTime GetDateTime { get; } = DateTime.Now;
    }
}
