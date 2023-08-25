using HotellistingAPI.Contracts;
using HotellistingAPI.Data;

namespace HotellistingAPI.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly HotelListingDbContext _context;
        private readonly IHotelsRepository hotelsRepository;
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
            
        }
    }
}
