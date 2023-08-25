using HotellistingAPI.Data;

namespace HotellistingAPI.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
