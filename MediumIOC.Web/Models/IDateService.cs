namespace MediumIOC.Web.Models
{
    public interface IDateService
    {
        DateTime GetDateTime { get; }
    }

    public interface ISingletonDateService:IDateService { }
    public interface IScoopedDateService:IDateService { }
    public interface ITransientDateService:IDateService { }
}
