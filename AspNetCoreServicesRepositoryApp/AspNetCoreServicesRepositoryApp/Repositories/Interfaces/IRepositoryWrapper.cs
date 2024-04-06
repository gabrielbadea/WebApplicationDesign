namespace AspNetCoreServicesRepositoryApp.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        ILocationRepository LocationRepository { get; }

        void Save();
    }
}
