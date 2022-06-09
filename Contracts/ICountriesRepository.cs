using api_dev_lessons.Data;

namespace api_dev_lessons.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}